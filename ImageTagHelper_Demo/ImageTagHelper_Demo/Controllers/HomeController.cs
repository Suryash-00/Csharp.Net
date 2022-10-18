using Microsoft.AspNetCore.Mvc;

namespace ImageTagHelper_Demo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
