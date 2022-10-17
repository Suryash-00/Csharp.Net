using Microsoft.AspNetCore.Mvc;

namespace TagHelpers_Demo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public int Details(int id)
        {
            return id;
        }
    }
}
