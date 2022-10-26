using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleWebApp
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.Use(async (context, next) =>
            {
                Console.WriteLine("before request");
                await next();
                Console.WriteLine("after request");
            });
            app.Run(async context =>
            {
                Console.WriteLine("hello world");
                await context.Response.WriteAsync("Hello World!");
                });
        }
    }
}