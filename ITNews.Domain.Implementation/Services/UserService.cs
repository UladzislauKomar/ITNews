using AutoMapper;
using ITNews.Data.Contracts.Entities;
using ITNews.Data.Contracts.Repositories;
using ITNews.Domain.Contracts.Services;
using ITNews.Domain.Contracts.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ITNews.Domain.Implementation.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository repository;
        private readonly IMapper mapper;
        private readonly UserManager<UserEntity> userManager;
        private readonly SignInManager<UserEntity> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public UserService(IUserRepository repository, IMapper mapper, UserManager<UserEntity> userManager, SignInManager<UserEntity> signInManager, RoleManager<IdentityRole> roleManager)
        {
            this.repository = repository;
            this.mapper = mapper;
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
        }

        public async Task<IdentityResult> SetRole(string userName, string roleName)
        {
            var entityUser = new UserEntity()
            {
                UserName = userName
            };
            var entity = repository.Read(entityUser); 
            try
            {
                var result = await userManager.AddToRoleAsync(entity, roleName);
                return result;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public async Task<IdentityResult> ChangeRole(UserViewModel model, string roleName)
        {
            var entity = repository.Read().FirstOrDefault(x => x.Id == model.Id);
            try
            {
                var roles = await userManager.GetRolesAsync(entity);
                await userManager.RemoveFromRolesAsync(entity, roles);
                var result = await userManager.AddToRoleAsync(entity, roleName);
                return result;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public UserViewModel GetProfile(UserViewModel model)
        {
            var entity = mapper.Map<UserViewModel, UserEntity>(model);
            var entityModel = repository.Read(entity);
            var output = mapper.Map<UserEntity, UserViewModel>(entityModel);
            return output;
        }

        public void EditProfile(UserViewModel model)
        {
            var entity = repository.Read().FirstOrDefault(x => x.Id == model.Id);
            mapper.Map<UserViewModel, UserEntity>(model, entity);
            repository.Update(entity);
        }

        public async Task<UserViewModel> GetCurrentUserAsync(HttpContext context)
        {
            var entity = await userManager.GetUserAsync(context.User);
            var model = mapper.Map<UserEntity, UserViewModel>(entity);
            return model;
        }

        public async Task ConfirmEmail(HttpContext context)
        {
            var entity = await userManager.GetUserAsync(context.User);
            entity.EmailConfirmed = true;
            repository.Update(entity);
        }

        public async Task<IdentityResult> Register(UserViewModel model)
        {
            var entity = mapper.Map<UserViewModel, UserEntity>(model);
            entity.UserName = model.UserName;
            var result = await userManager.CreateAsync(entity, model.PasswordHash);
            if (result.Succeeded)
            {
                await signInManager.SignInAsync(entity, false);
                await userManager.AddToRoleAsync(entity, "readonly");
            }
            return result;
        }

        public async Task<SignInResult> Login(UserViewModel model)
        {
            var result = await signInManager.PasswordSignInAsync(model.UserName, model.PasswordHash, false, false);
            return result;
        }

        public async Task LogOut()
        {
            await signInManager.SignOutAsync();
        }
       
        private async Task<IList<UserViewModel>> GetUsersByRoleAsync(string roleName)
        {
            var entities = await userManager.GetUsersInRoleAsync(roleName.ToLower());
            var models = mapper.Map<IList<UserEntity>, IList<UserViewModel>>(entities);
            return models;
        }

        public IEnumerable<UserViewModel> GetUsers()
        {
            var entities = repository.Read();
            var models = mapper.Map<IEnumerable<UserEntity>, IEnumerable<UserViewModel>>(entities);
            return models;
        }

        public async Task<string> GetRoleAsync(UserViewModel model)
        {
            var entity = mapper.Map<UserViewModel, UserEntity>(model);
            var role = await userManager.GetRolesAsync(entity);
            return role.First();
        }

        public void DeleteUser(UserViewModel model)
        {
            var entity = repository.Read().FirstOrDefault(x => x.Id == model.Id);
            mapper.Map<UserViewModel, UserEntity>(model, entity);
            try
            {
                repository.Delete(entity);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}
