using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebApplication1.DAL;
using WebApplication1.Helpers;
using WebApplication1.Models;

namespace WebApplication1
{
    public class Startup
    {
        private readonly IConfiguration _config;
        public Startup(IConfiguration config)
        {
            _config = config;
        }
       
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddIdentity<AppUser, IdentityRole>(identityOptions =>
            {
                identityOptions.Password.RequiredLength = 8;
                identityOptions.Password.RequireNonAlphanumeric = true;
                identityOptions.Password.RequireLowercase = true;
                identityOptions.Password.RequireUppercase = true;
                identityOptions.Password.RequireDigit = true;

                //unique email icazesi 
                identityOptions.User.RequireUniqueEmail = true;

                //3 defe sehv yigmaga icaze verilir
                identityOptions.Lockout.MaxFailedAccessAttempts = 3;
                //10 deiqeden sonra aktiv edilsin
                identityOptions.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(10);
                //teze user ucun yuxardaki iki sert odenmesin
                identityOptions.Lockout.AllowedForNewUsers = true;
                //AppDbContext-de istifade edecem yuxardakialri
            }).AddEntityFrameworkStores<AppDbContext>()
            .AddDefaultTokenProviders().AddErrorDescriber<IdentityErrorsDescriptionAz>();


            services.AddDbContext<AppDbContext>(options=> {
                options.UseSqlServer(_config["ConnectionStrings:DefaultConnection"]);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseAuthentication();
            app.UseStaticFiles();

            app.UseMvc(routes=> {

               routes.MapRoute(
                name: "areas",
                template: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}"
                 );

                routes.MapRoute(
                    "default",
                    "{controller=Home}/{action=Index}/{id?}"
                    );
            });
           
        }
    }
}
