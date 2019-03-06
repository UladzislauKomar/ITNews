using System.Collections.Generic;
using System.Threading.Tasks;
using ITNews.Domain.Contracts.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ITNews.Domain.Contracts.Services
{
    public interface IUserService
    {
        Task<IdentityResult> ChangeRole(UserViewModel model, string roleName);
        void EditProfile(UserViewModel model);
        Task<UserViewModel> GetCurrentUserAsync(HttpContext context);
        UserViewModel GetProfile(UserViewModel model);
        Task<SignInResult> Login(UserViewModel model);
        Task LogOut();
        Task<IdentityResult> Register(UserViewModel model);
        Task<IdentityResult> SetRole(string userName, string roleName);
        IEnumerable<UserViewModel> GetUsers();
        Task<string> GetRoleAsync(UserViewModel model);
        void DeleteUser(UserViewModel model);
        Task ConfirmEmail(HttpContext context);
    }
}