using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITNews.Domain.Contracts.Services;
using ITNews.Domain.Contracts.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace ITNews.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService userService;
        private readonly IEmailSenderService emailSenderService;

        private readonly IStringLocalizer<UserController> localizer;

        public UserController(IUserService userService, IEmailSenderService emailSenderService, IStringLocalizer<UserController> localizer)
        {
            this.userService = userService;
            this.emailSenderService = emailSenderService;
            this.localizer = localizer;
        }

        [HttpGet]
        [Authorize]
        public IActionResult Profile(string userName)
        {
            var user = new UserViewModel()
            {
                UserName = userName
            };
            var model = userService.GetProfile(user);
            ViewData["role"] = userService.GetRoleAsync(model).Result;

            ViewData["Birthdate"] = localizer["Birthdate"];
            ViewData["About"] = localizer["About"];
            ViewData["Edit"] = localizer["Edit"];
            ViewData["Delete"] = localizer["Delete"];
            ViewData["Cancel"] = localizer["Cancel"];
            ViewData["Firstname"] = localizer["Firstname"];
            ViewData["Lastname"] = localizer["Lastname"];
            ViewData["NoPosts"] = localizer["NoPosts"];
            ViewData["At"] = localizer["At"];

            return View(model);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Profile(UserViewModel model, string userId)
        {
            if (ModelState.IsValid)
            {
                var user = await userService.GetCurrentUserAsync(HttpContext);
                user.FirstName = model.FirstName;
                user.LastName = model.LastName;
                user.Description = model.Description;
                user.Birthdate = model.Birthdate;
                userService.EditProfile(user);
            }
            return RedirectToAction("Profile", new { userName = model.UserName });
        }

        [Route("Account/Register")]
        [HttpGet]
        public IActionResult Register()
        {
            ViewData["UserName"] = localizer["UserName"];
            ViewData["Password"] = localizer["Password"];
            ViewData["ConfirmPassword"] = localizer["ConfirmPassword"];
            ViewData["Register"] = localizer["Register"];

            return View(new RegisterViewModel());
        }

        [Route("Account/Register")]
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new UserViewModel()
                {
                    Email = model.Email,
                    UserName = model.UserName,
                    PasswordHash = model.Password,
                };
                var result = await userService.Register(user);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "News");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
            return View(model);
        }

        [Route("Account/Login")]
        [HttpGet]
        public IActionResult Login()
        {
            ViewData["Login"] = localizer["Login"];
            ViewData["UserName"] = localizer["UserName"];
            ViewData["Password"] = localizer["Password"];

            return View(new UserViewModel());
        }
        
        [Route("Account/Login")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(UserViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await userService.Login(model);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "News");
                }
                else
                {
                    ModelState.AddModelError("", "Login failed");
                }
            }
            return View();
        }

        [Route("Account/AccessDenied")]
        [HttpGet]
        public IActionResult AccessDenied(string returnUrl)
        {
            ViewData["AccessDenied"] = localizer["AccessDenied"];

            return View();
        }

        [Route("Account/Logout")]
        [HttpGet]
        public IActionResult LogOut()
        {
            try
            {
                userService.LogOut();
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return RedirectToAction("Index", "News");
        }

        [HttpGet]
        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );

            return RedirectToAction("Index", "News");
        }

        [HttpGet]
        public async Task<IActionResult> ConfirmEmail()
        {
            var user = await userService.GetCurrentUserAsync(HttpContext);
            if (!user.EmailConfirmed)
            {
                var confirmationLink = "http://notrealkomar-001-site1.btempurl.com/" + Url.Action("ConfirmedEmail", "User", new { userId = user.Id, token = user.SecurityStamp });
                var message = $"Click this <a href=\"{confirmationLink}\">link</a> to confirm your email";
                await emailSenderService.SendEmailAsync(user.Email, "Email Confirmation", message);

                ViewData["ConfirmEmail"] = localizer["ConfirmEmail"];
                return View();
            }

            return RedirectToAction("AccessDenied", "User");
        }

        [HttpGet]
        public async Task<IActionResult> ConfirmedEmail(string userId, string token)
        {
            var user = await userService.GetCurrentUserAsync(HttpContext);
            if (!user.EmailConfirmed)
            {
                if (user.Id == userId && user.SecurityStamp == token)
                {
                    try
                    {
                        await userService.ConfirmEmail(HttpContext);

                        ViewData["ConfirmedEmail"] = localizer["ConfirmedEmail"];
                        return View();
                    }
                    catch (Exception exception)
                    {
                        throw exception;
                    }
                }
            }
            return RedirectToAction("AccessDenied", "User");
        }
    }
}