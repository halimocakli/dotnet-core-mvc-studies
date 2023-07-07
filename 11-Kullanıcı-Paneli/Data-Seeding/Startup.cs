using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Data_Seeding.Models;
using Data_Seeding.RepositoryPattern.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data_Seeding.RepositoryPattern.Interfaces;
using Data_Seeding.Context;
using Data_Seeding.RepositoryPattern.Concreate;

namespace Data_Seeding
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
            //services.AddScoped<IRepository<BookType>, Repository<BookType>>();
            // services.AddScoped<IRepository<Author>, Repository<Author>>();
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<IAuthorRepository, AuthorRepository>();
            services.AddScoped<IBookTypeRepository, BookTypeRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, MyDbContext context)
        {
            context.Database.Migrate();
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
