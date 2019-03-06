using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITNews.Domain.Contracts.Services;
using ITNews.Domain.Contracts.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ITNews.Web.Controllers
{
    [Authorize(Roles = "admin")]
    public class AdminController : Controller
    {
        private readonly IUserService userService;

        public AdminController(IUserService userService)
        {
            this.userService = userService;
        }

        // GET: Admin
        public ActionResult Index()
        {
            var models = userService.GetUsers();
            return View(models);
        }
        
        public ActionResult Edit(string userId)
        {
            var userModel = new UserViewModel
            {
                Id = userId
            };
            var model = userService.GetProfile(userModel);
            ViewData["model"] = model;
            return View(model);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(UserViewModel model, string userId)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid && model.Id != string.Empty)
                {
                    userService.EditProfile(model);
                    string roleName = Request.Form["role"];
                    await userService.ChangeRole(model, roleName);
                }

                return RedirectToAction(nameof(Index));
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public ActionResult Delete(string userId)
        {
            var UserModel = new UserViewModel
            {
                Id = userId
            };
            var model = userService.GetProfile(UserModel);
            ViewData["model"] = model;
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(UserViewModel model, string userId)
        {
            try
            {
                // TODO: Add delete logic here
                var user = new UserViewModel
                {
                    Id = userId
                };
                userService.DeleteUser(user);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}