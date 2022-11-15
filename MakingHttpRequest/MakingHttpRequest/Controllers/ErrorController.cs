using Microsoft.AspNetCore.Mvc;

namespace MakingHttpRequest.Controllers
{
    [ApiController]
    public class ErrorController : Controller
    {
        [Route("/error")]
        public IActionResult Error()
        {
            return Problem();
        }
    }
}
