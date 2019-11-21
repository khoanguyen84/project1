using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityApp.Models;
using IdentityApp.Models.Account;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IdentityApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;

        public AccountController(UserManager<ApplicationUser> _userManager, SignInManager<ApplicationUser> _signInManager)
        {
            userManager = _userManager;
            signInManager = _signInManager;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register([FromBody] RegisterModel model)
        {
            try
            {
                if (model != null)
                {
                    var user = new ApplicationUser()
                    {
                        UserName = model.Email,
                        Email = model.Email
                    };

                    var registerResult =  await userManager.CreateAsync(user, model.Password);
                    if (registerResult.Succeeded)
                    {
                        return new JsonResult(new { status = 1, message = "User has been registered successfully." });
                    }
                    else
                    {
                        return new JsonResult(new { status = 0, message = registerResult.Errors.FirstOrDefault().Description });
                    }
                }
                return new JsonResult(new { status = -1, message = "Something went wrong, please contact administration." });
            }
            catch (Exception ex)
            {
                return new JsonResult(new { status = -1, message = "Something went wrong, please contact administration." });
            }
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginModel model)
        {
            try
            {
                if (model != null)
                {
                    var user = await userManager.FindByNameAsync(model.Email);
                    
                    if (user != null)
                    {
                        var loginUser = await userManager.CheckPasswordAsync(user, model.Password);
                        if (loginUser)
                        {
                            //await signInManager.SignInAsync(user, isPersistent: false);
                            var loginResult =  await signInManager.PasswordSignInAsync(model.Email, model.Password, isPersistent: model.RememberMe, false);
                            if (loginResult.Succeeded)
                            {
                                return new JsonResult(new { status = 1, message = "" });
                            }
                        }
                    }
                }
                return new JsonResult(new { status = -1, message = "Something went wrong, please contact administration." });
            }
            catch (Exception ex)
            {
                return new JsonResult(new { status = -1, message = "Something went wrong, please contact administration." });
            }
        }

        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}