using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Repository_Metotlarının_Kullanımı.Context;
using Repository_Metotlarının_Kullanımı.Models;
using Repository_Metotlarının_Kullanımı.RepositoryPattern.Base;
using Repository_Metotlarının_Kullanımı.RepositoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository_Metotlarının_Kullanımı
{
    public class Startup
    {
        readonly IConfiguration _configuration;
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<MyDbContext>(options => options.UseSqlServer(_configuration["ConnectionStrings:MsSql"]));
            services.AddControllersWithViews();
            services.AddScoped<IRepository<BookType>, Repository<BookType>>();
            services.AddScoped<IRepository<Author>, Repository<Author>>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                app.UseEndpoints(endpoints =>
                {
                    endpoints.MapControllerRoute("CustomRoute", "{controller=home}/{action=Index}/{id?}");
                });
            });
        }
    }
}
