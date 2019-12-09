using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using IdentityApp.Areas.Admin.Models.Role;
using IdentityApp.Areas.Admin.Models.User;
using IdentityApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IdentityApp.Areas.Admin.Controllers
{
    [Authorize]
    [Area("Admin")]
    public class DashboardController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<ApplicationRole> roleManager;

        public DashboardController(UserManager<ApplicationUser> _userManager, RoleManager<ApplicationRole> _roleManager)
        {
            userManager = _userManager;
            roleManager = _roleManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult Gets()
        {
            try
            {
                var draw = HttpContext.Request.Form["draw"].FirstOrDefault();
                // Skiping number of Rows count  
                var start = Request.Form["start"].FirstOrDefault();
                // Paging Length 10,20  
                var length = Request.Form["length"].FirstOrDefault();
                // Sort Column Name  
                var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
                // Sort Column Direction ( asc ,desc)  
                var sortColumnDirection = Request.Form["order[0][dir]"].FirstOrDefault();
                // Search Value from (Search box)  
                var searchValue = Request.Form["search[value]"].FirstOrDefault();

                //Paging Size (10,20,50,100)  
                int pageSize = length != null ? Convert.ToInt32(length) : 0;
                int skip = start != null ? Convert.ToInt32(start) : 0;
                int recordsTotal = 0;

                // Getting all Customer data  
                var users = (from u in userManager.Users
                                    select new UserView()
                                    {
                                        Address = u.Address,
                                        Gender = u.Gender ? "Male" : "Female",
                                        UserId = u.Id,
                                        UserName = u.UserName,
                                        DOB = u.DOB.ToString("dd/MM/yyyy")
                                    }).ToList();
                foreach(var user in users)
                {
                    user.Roles = GetRolesByUser(user.UserId);
                }

                //Sorting  
                if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnDirection)))
                {
                    var property = GetProperty(sortColumn);
                    if (sortColumnDirection == "asc")
                    {
                        users = users.OrderBy(property.GetValue).ToList();
                    }
                    else
                    {
                        users = users.OrderByDescending(property.GetValue).ToList();
                    }
                }
                //Search  
                if (!string.IsNullOrEmpty(searchValue))
                {
                    users = users.Where(m => m.UserName.ToLower().Contains(searchValue.ToLower())
                                        || (!string.IsNullOrEmpty(m.Address) && m.Address.ToLower().Contains(searchValue.ToLower()))
                                        || (!string.IsNullOrEmpty(m.Roles) && m.Roles.ToLower().Contains(searchValue.ToLower()))).ToList();
                }

                //total number of rows count   
                recordsTotal = users.Count();
                //Paging   
                var data = users.Skip(skip).Take(pageSize).ToList();
                //Returning Json Data  
                return Json(new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data });
            }
            catch (Exception ex)
            {
                return new JsonResult(new
                {
                    status = -1,
                    message = "Something went wrong, please contact administrator."
                });
            }

        }

        public IActionResult Get(string id)
        {
            var user = new UserDetail();
            try
            {
                user = (from u in userManager.Users
                        where u.Id == id
                        select new UserDetail()
                        {
                            Address = u.Address,
                            Gender = u.Gender,
                            UserId = u.Id,
                            UserName = u.UserName,
                            DOB = u.DOB.ToString("yyyy-MM-dd"),
                        }).FirstOrDefault();
                var applicationUser = new ApplicationUser()
                {
                    Id = user.UserId,
                    UserName = user.UserName,
                    Email = user.UserName
                };
                var rolesInUser = Task.Run(async () => await userManager.GetRolesAsync(applicationUser)).Result;
                user.Roles = rolesInUser.ToArray();
                return new JsonResult(new { status = 1, response = user });
            }
            catch (Exception ex)
            {

            }
            return new JsonResult(new { status = -1, response = user });
        }

        [HttpPost]
        public async Task<IActionResult> Save([FromBody] UserSave model)
        {
            try
            {
                if (model != null)
                {
                    //create new student
                    if (string.IsNullOrEmpty(model.UserId))
                    {
                        var user = new ApplicationUser()
                        {
                            UserName = model.UserName,
                            Email = model.UserName,
                            DOB = model.DOB,
                            Gender = model.Gender,
                            Address = model.Address
                        };
                        var registerResult = await userManager.CreateAsync(user, "Asdf1234!");
                        if (registerResult.Succeeded)
                        {
                            if (model.Roles != null)
                            {
                                foreach (var role in model.Roles)
                                {
                                    var userInRole = await roleManager.FindByIdAsync(role);
                                    IdentityResult result = null;
                                    if (userInRole != null)
                                    {
                                        result = await userManager.AddToRoleAsync(user, userInRole.Name);
                                    }
                                }
                            }
                            return new JsonResult(new { status = 1, message = "User has been created successfully." });
                        }
                        else
                        {
                            return new JsonResult(new { status = 0, message = registerResult.Errors.FirstOrDefault().Description });
                        }
                    }
                    else //update student by StudentId
                    {
                        var userDetail = await userManager.FindByIdAsync(model.UserId);
                        userDetail.UserName = model.UserName;
                        userDetail.Gender = model.Gender;
                        userDetail.Address = model.Address;
                        userDetail.DOB = model.DOB;
                        userDetail.Id = model.UserId;

                        var updateResult = await userManager.UpdateAsync(userDetail);
                        if (updateResult.Succeeded)
                        {
                            var userRoles = await userManager.GetRolesAsync(userDetail);
                            if(userRoles != null)
                            {
                                var result = await userManager.RemoveFromRolesAsync(userDetail, userRoles);
                            }
                            if(model.Roles != null)
                            {
                                foreach(var role in model.Roles)
                                {
                                    var userInRole = await roleManager.FindByIdAsync(role);
                                    IdentityResult result = null;
                                    if(userInRole != null)
                                    {
                                        if(!(await userManager.IsInRoleAsync(userDetail, userInRole.Name)))
                                        {
                                            result = await userManager.AddToRoleAsync(userDetail, userInRole.Name);

                                        }
                                    }
                                }
                            }
                            return new JsonResult(new
                            {
                                status = 1,
                                message = "User has been updated successfully."
                            });
                        }
                        else
                        {
                            return new JsonResult(new { status = 0, message = updateResult.Errors.FirstOrDefault().Description });
                        }
                    }

                }
                return new JsonResult(new
                {
                    status = -1,
                    message = "Something went wrong, please contact administrator."
                });
            }
            catch (Exception ex)
            {
                return new JsonResult(new
                {
                    status = -1,
                    message = "Something went wrong, please contact administrator."
                });

            }
        }

        [HttpGet]
        public async Task<IActionResult> Delete(string id)
        {
            try
            {
                if (!string.IsNullOrEmpty(id))
                {
                    var userDetail = await userManager.FindByIdAsync(id);

                    if(userDetail != null)
                    {
                        var userRoles = await userManager.GetRolesAsync(userDetail);
                        if (userRoles != null)
                        {
                            var result = await userManager.RemoveFromRolesAsync(userDetail, userRoles);
                        }
                        var deleteResult = await userManager.DeleteAsync(userDetail);
                        if (deleteResult.Succeeded)
                        {
                            return new JsonResult(new { status = 1, message = "User has been deleted successfully." });
                        }
                        else
                        {
                            return new JsonResult(new { status = 0, message = deleteResult.Errors.FirstOrDefault().Description });
                        }
                    }
                    
                }
                return new JsonResult(new { status = -1, message = "Something went wrong, please contact administrator." });
            }
            catch (Exception ex)
            {
                return new JsonResult(new { status = -1,  message = "Something went wrong, please contact administrator." });
            }
        }

        private PropertyInfo GetProperty(string columnName)
        {
            var properties = typeof(UserView).GetProperties();
            PropertyInfo prop = null;
            foreach (var property in properties)
            {
                if (property.Name.ToLower().Equals(columnName.ToLower()))
                {
                    prop = property;
                    break;
                }
            }
            return prop;
        }

        private string GetRolesByUser(string userId)
        {
            var userDetail = Task.Run(async() => await userManager.FindByIdAsync(userId)).Result;
            var userRoles = Task.Run(async() => await userManager.GetRolesAsync(userDetail)).Result;
            string roles = userRoles != null ? string.Join(", ", userRoles) : string.Empty;
            return roles;
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}