using IdentityApp.Areas.Admin.Models.Role;
using IdentityApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityApp.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class RoleController : Controller
    {
        private readonly RoleManager<ApplicationRole> roleManager;
        private readonly UserManager<ApplicationUser> userManager;

        public RoleController(RoleManager<ApplicationRole> _roleManager, UserManager<ApplicationUser> _userManager)
        {
            roleManager = _roleManager;
            userManager = _userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Gets()
        {
            var roles = new List<RoleViewModel>();
            try
            {
                roles = await roleManager.Roles.ToAsyncEnumerable().Select(r => new RoleViewModel() { 
                    RoleKey = r.Id,
                    RoleName = r.Name
                }).ToList();
            }
            catch(Exception ex)
            {

            }
            return Json(new { response = roles, status = 1 });
        }

        [HttpPost]
        public async Task<IActionResult> Save([FromBody] SaveRoleModel model)
        {
            try
            {
                if(model != null && !string.IsNullOrEmpty(model.RoleName))
                {
                    
                    if (string.IsNullOrEmpty(model.RoleKey))
                    {
                        var addRole = new ApplicationRole()
                        {
                            Name = model.RoleName,
                            Id = Guid.NewGuid().ToString()
                        };

                        var createResult = await roleManager.CreateAsync(addRole);
                        if (createResult.Succeeded)
                        {
                            return Json(new { status = 1, message = "Role has been created successfully." });
                        }
                        else
                        {
                            return Json(new { status = -1, message = createResult.Errors.FirstOrDefault().Description });
                        }
                    }
                    else
                    {
                        var updateRole = await roleManager.FindByIdAsync(model.RoleKey);
                        if(updateRole != null)
                        {
                            updateRole.Name = model.RoleName;
                            var updateResult = await roleManager.UpdateAsync(updateRole);
                            if (updateResult.Succeeded)
                            {
                                return Json(new { status = 1, message = "Role has been updated successfully." });
                            }
                            else
                            {
                                return Json(new { status = -1, message = updateResult.Errors.FirstOrDefault().Description });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return Json(new { status = -1, message = "Something went wrong, please contact administartor." });
        }

        public async Task<IActionResult> Get(string id)
        {
            var role = new RoleViewModel();
            try
            {
                var identityRole = await roleManager.FindByIdAsync(id);
                if(identityRole != null)
                {
                    role.RoleKey = id;
                    role.RoleName = identityRole.Name;
                }
            }
            catch (Exception ex)
            {

            }
            return Json(new { response = role, status = 1 });
        }

        public async Task<IActionResult> Delete(string id)
        {
            try
            {
                var identityRole = await roleManager.FindByIdAsync(id);
                if (identityRole != null)
                {
                    var deleteResult = await roleManager.DeleteAsync(identityRole);
                    if (deleteResult.Succeeded)
                    {
                        return Json(new { status = 1, message = "Role has been deleted successfully." });
                    }
                    else
                    {
                        return Json(new { status = -1, message = deleteResult.Errors.FirstOrDefault().Description });
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return Json(new { status = -1, message = "Something went wrong, please contact administartor." });
        }
    }
}
