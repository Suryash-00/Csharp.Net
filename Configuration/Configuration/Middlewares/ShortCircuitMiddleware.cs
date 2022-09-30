using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Configuration.Middlewares
{
    public class ShortCircuitMiddleware
    {
        private RequestDelegate nextDelegate;
        public ShortCircuitMiddleware(RequestDelegate next) => nextDelegate = next;
        public async Task Invoke(HttpContext httpContext)
        {
            //if (httpContext.Request.Headers["User-Agent"].Any(v => v.Contains("Firefox")))      //If you now run your application and open the URL – https://localhost:44343/middleware in Firefox browser. You will receive a blank page. For other browsers you will get the same response which you get previously.
            if (httpContext.Items["Chrome"] as bool? == true)
            {
                httpContext.Response.StatusCode = StatusCodes.Status401Unauthorized;
            }
            else
            {
                await nextDelegate.Invoke(httpContext);
            }
        }
    }
}