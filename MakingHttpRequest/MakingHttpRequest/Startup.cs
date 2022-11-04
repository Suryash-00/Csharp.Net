using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Polly;

namespace MakingHttpRequest
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
            services.AddControllers();

            var timeout= Policy.TimeoutAsync<HttpResponseMessage>(TimeSpan.FromSeconds(5));

            services.AddHttpClient<IWeatherService, WeatherService>(c =>
            {
                c.BaseAddress = new Uri("http://api.weatherapi.com/v1/current.json");
            }).AddTransientHttpErrorPolicy(policy=> policy.WaitAndRetryAsync(3, _ => TimeSpan.FromSeconds(2))).     //retry 3 times after every 2 seconds
            AddTransientHttpErrorPolicy(policy=> policy.CircuitBreakerAsync(5, TimeSpan.FromSeconds(5))).
            AddPolicyHandler(request =>
            {
                if (request.Method == HttpMethod.Get)
                    return timeout;
                return Policy.NoOpAsync<HttpResponseMessage>();
            });        //anytime when there are 5 consecutive requests, it waits for 5 request to fail and break the circuit

            // Alternatively you can also add extension methods like below to keep this method clean
            // services.AddWeatherService();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
