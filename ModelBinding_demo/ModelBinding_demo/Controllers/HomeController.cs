using Microsoft.AspNetCore.Mvc;

namespace ModelBinding_demo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public string Details(int id, string name)
        {
            return "Id = " + id + "Name = " + name;
        }
    }
}
