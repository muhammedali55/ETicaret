using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity.Entities;
using ETicaret.Authentication;
using ETicaret.Utility;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ETicaret
{
    public class Startup
    {
        IConfiguration Configuration;

        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }
    public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddDbContext<UserContext>();

            services.AddIdentity<User, IdentityRole>(opt=> {
                // �ifrenin minimum uzunlu�u
                opt.Password.RequiredLength = 8;
                // �ifre i�inde enaz bir rakam olacak
                opt.Password.RequireDigit = true;
                // �ifrede enaz bir k���k harf olacak
                opt.Password.RequireLowercase = true;
                // �ifre i�ind enaz bir b�y�k harf olacak
                opt.Password.RequireUppercase = true;
                // enaz bir �zel karakter olacak
                opt.Password.RequireNonAlphanumeric = true;
                // istenilel bir karakterin bulunmas� zorunlu tutulabilir.(?)
                //opt.Password.RequiredUniqueChars = '?';
                // �stenirse kullan�c� ad� belirlenirken belli karakterlerin kullan�lmass� zorunlu k�l�nabilir.
                //opt.User.AllowedUserNameCharacters = "aasdflkdskjfdfskdfsmlsfkSADFSFDAMNAFD-?";  
                // E Posta n�n benzersiz olmas�n� zorunlu k�lar.
                opt.User.RequireUniqueEmail = true;
            })
                .AddEntityFrameworkStores<UserContext>()
                .AddErrorDescriber<CustumErrors>()
                .AddDefaultTokenProviders();
           
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseStaticFiles();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapAreaControllerRoute();
                endpoints.MapAreaControllerRoute(
                    name:"AdminPaneli",
                    areaName:"Administrator",
                    pattern: "Administrator/{controller=Home}/{action=Index}/{id?}"
                    );
                endpoints.MapAreaControllerRoute(
                    name:"KullaniciPaneli",
                    areaName:"Users",
                    pattern: "KullaniciPaneli/{controller=Home}/{action=Index}/{id?}"
                    );
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern:"{controller=Home}/{action=Index}/{id?}"
                    );
            });
        }
    }
}
