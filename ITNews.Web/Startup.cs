using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ITNews.Data.Contracts.Entities;
using ITNews.Data.Contracts.Repositories;
using ITNews.Data.Implementation.Context;
using ITNews.Data.Implementation.Repositories;
using ITNews.Domain.Contracts.Services;
using ITNews.Domain.Contracts.ViewModels;
using ITNews.Domain.Implementation.Services;
using ITNews.Infrastructure;
using ITNews.Web.Hubs;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ITNews.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddOptions();

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContext<ITNewsDbContext>(options => 
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<UserEntity, IdentityRole>(config =>
                {
                    config.User.RequireUniqueEmail = true;
                })
                .AddEntityFrameworkStores<ITNewsDbContext>()
                .AddDefaultTokenProviders();

            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new ITNewsWebProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            services.AddLocalization(options => options.ResourcesPath = "Resources");

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                .AddViewLocalization();

            services.AddScoped<ICommentLikeRepository, CommentLikeRepository>();
            services.AddScoped<ICommentRepository, CommentRepository>();
            services.AddScoped<INewsRepository, NewsRepository>();
            services.AddScoped<INewsRatingRepository, NewsRatingRepository>();
            services.AddScoped<INewsTagRepository, NewsTagRepository>();
            services.AddScoped<ISectionRepository, SectionRepository>();
            services.AddScoped<ITagRepository, TagRepository>();
            services.AddScoped<IUserRepository, UserRepository>();

            services.AddScoped<ICommentLikeService, CommentLikeService>();
            services.AddScoped<ICommentService, CommentService>();
            services.AddScoped<INewsService, NewsService>();
            services.AddScoped<INewsRatingService, NewsRatingService>();
            services.AddScoped<INewsTagService, NewsTagService>();
            services.AddScoped<ISectionService, SectionService>();
            services.AddScoped<ITagService, TagService>();
            services.AddScoped<IUserService, UserService>();

            services.AddTransient<IEmailSenderService, EmailSenderService>();

            services.AddSignalR();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            var supportedCultures = new[]
            {
                new CultureInfo("en"),
                new CultureInfo("ru")
            };

            app.UseRequestLocalization(new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture("ru"),
                SupportedCultures = supportedCultures,
                SupportedUICultures = supportedCultures
            });

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseCookiePolicy(); 

            app.UseSignalR(routes =>
            {
                routes.MapHub<AllHub>("/allHub");
            });

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "custom",
                    template: "{controller=News}/{action=Index}/{id?}");

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
