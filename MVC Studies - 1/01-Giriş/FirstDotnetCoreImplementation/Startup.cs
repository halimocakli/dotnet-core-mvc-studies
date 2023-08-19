﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstDotnetCoreImplementation
{
    public class Startup
    {

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        // Middleware katmanı için bu metot kullanılacak.
        // Request - Respons işlemlerine müdahale etmemizi sağlayan ara katmandır.
        // app. ile başlayan ifadeler middleware olarak kabul edilir.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            // Ulaşacağımız sayfanın şablonunu verir.
            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapGet("/test", async context =>
                //{
                //    await context.Response.WriteAsync("Hello World!");
                //});

                // MapDefaultControllerRoute() metodunun varsayılan parametreleri ->> {controller=Home}/{action=Index}/{id?}
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
