using DataAccess.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI
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

            //veritabaný
            services.AddDbContext<ProjectContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            //services.AddDatabaseDeveloperPageExceptionFilter();

            //Kimlik yönetimi
            services.AddIdentity<IdentityUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ProjectContext>().AddDefaultTokenProviders();

            //mvc
            services.AddControllersWithViews();

            //BaseRepository kullanmak için
            //services.AddTransient<IRepository<Category>, BaseRepository<Category>>();

            //instance

            //IOCContainer.ConfigureIoc(services);
            services.AddSession(x =>
            {
                x.Cookie.Name = "project_cart";
                x.IdleTimeout = TimeSpan.FromMinutes(1);
            });


            services.ConfigureApplicationCookie(x =>
            {
                x.LoginPath = new Microsoft.AspNetCore.Http.PathString("/Home/Login");
                x.Cookie = new Microsoft.AspNetCore.Http.CookieBuilder
                {
                    Name = "Login_Cookie"
                };
                x.SlidingExpiration = true;
                x.ExpireTimeSpan = TimeSpan.FromMinutes(1);
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                //app.UseMigrationsEndPoint();
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
                //Area route
                app.UseEndpoints(endpoints =>
                {
                    endpoints.MapControllerRoute(
                      name: "areas",
                      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                    );
                });
                //Confirmation route
                endpoints.MapControllerRoute(
                    name: "confirmation",
                    pattern: "{controller=Home}/{action=Confirmation}/{id}/{registerCode}");

                //update card
                endpoints.MapControllerRoute(
                    name: "update_cart",
                    pattern: "{controller=Home}/{action=UpdateCartItem}/{id}/{quantity}");


                //default route
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

            });
        }
    }
}
    
