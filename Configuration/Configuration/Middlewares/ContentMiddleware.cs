using System.Threading.Tasks;
using Configuration.Services;
using Microsoft.AspNetCore.Http;

namespace Configuration.Middlewares
{
    public class ContentMiddleware
    {
        private RequestDelegate nextDelegate;
        private TotalUsers totalUsers;
        public ContentMiddleware(RequestDelegate next, TotalUsers tu)
        {
            nextDelegate = next;
            totalUsers = tu;
        }
        public async Task Invoke(HttpContext httpContext)   //This method is called when .NET receives an HTTP request. HttpContext contains Information about the HTTP request and the response that will be returned to the client.
        {
            if (httpContext.Request.Path.ToString() == "/middleware")   //inspects the HTTP request and checks to see whether the request has been sent to the url /middleware. 
            {
                await httpContext.Response.WriteAsync("This is from the content middleware, Total Users: " + totalUsers.TUsers());
            }
            else
            {
                await nextDelegate.Invoke(httpContext);     // If a different URL has been initiated, then the request is forwarded to the next Middleware in the line. 
            }
        }
    }
}
