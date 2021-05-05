using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Tablet.Data;
using Tablet.Data.interfaces;
using Tablet.Data.Models;
using Tablet.Data.Repository;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace Tablet
{
    public class Startup
    {
        private IConfigurationRoot _confString;

        public Startup(Microsoft.AspNetCore.Hosting.IHostingEnvironment hostEnv) {
            _confString = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("dbsettings.json").Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDBContent>(options => options.UseSqlServer(_confString.GetConnectionString("DefaultConnection")));
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
        .AddCookie(options => //CookieAuthenticationOptions
        {
            options.LoginPath = new Microsoft.AspNetCore.Http.PathString("/Account/Login");
        });
            services.AddTransient<IProject, ProjectRepository>();
            services.AddTransient<MainModel>();
            services.AddTransient<ProjectPageModel>();
            services.AddTransient<MeetingPageModel>();
            services.AddTransient<ProjectModels>();
            services.AddTransient<RestrictionsPageModel>();
            services.AddTransient<IGeneralDevelopment, GeneralDevelopmentRepository>();
            services.AddTransient<IStructure, SructureRepository>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            
            services.AddMvc(option => option.EnableEndpointRouting = false);
            services.AddMemoryCache();
            services.AddSession();
            services.AddRazorPages();


            services.AddControllersWithViews();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseSession();
            app.UseRouting();


            using (var scope = app.ApplicationServices.CreateScope())
            {
                AppDBContent content = scope.ServiceProvider.GetRequiredService<AppDBContent>();
                DBObjects.Initial(content);
            }

            app.UseAuthentication();    // аутентификация
            app.UseAuthorization();     // авторизация

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            

        }
    }
}
