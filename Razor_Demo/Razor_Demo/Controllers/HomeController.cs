using Microsoft.AspNetCore.Mvc;

namespace Razor_Demo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
