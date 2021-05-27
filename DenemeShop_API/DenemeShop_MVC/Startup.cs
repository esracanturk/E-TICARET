using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DenemeShop_MVC.Interfaces;
using DenemeShop_MVC.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.IdentityModel.Tokens;

namespace DenemeShop_MVC
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
            services.AddAuthorization(options =>
            {
                options.AddPolicy("RequireAdministratorRole",
                    policy => policy.RequireRole("admin", "1"));
            });
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(o =>
            {
                o.LoginPath = "/Home/GirisSayfa";
                //o.LogoutPath = "/account/logout";
                //o.AccessDeniedPath = "/account/forbidden";
                //o.SlidingExpiration = true;
                o.ExpireTimeSpan = new TimeSpan(0, 20, 0);

                o.Cookie.Name = "cookieBu";
                o.AccessDeniedPath = new PathString("/Home/Index"); //yetkisiz kiþiler buraya gider

            });

            services.AddSession();
            services.AddMvc().AddSessionStateTempDataProvider();
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddSingleton<IProductService, ProductService>();
            services.AddSingleton<IAdminService, AdminService>();
            services.AddSingleton<ISepetService, SepetService>();
            services.AddControllersWithViews().AddRazorRuntimeCompilation();
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
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
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseSession();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
