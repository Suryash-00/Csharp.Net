using Microsoft.AspNetCore.Mvc;
namespace API_Demo.Controllers
{
    [ApiController]
    [Route("test/{action}")]
    public class TestController : ControllerBase
    {
        public string Get()
        {
            return "Returning from TestController Get Method";
        }
        public string Get2()
        {
            return "Returning from TestController Get2 Method";
        }
    }
}
