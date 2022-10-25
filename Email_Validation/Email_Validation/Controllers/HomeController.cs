using Range_Validation.Models;
using Microsoft.AspNetCore.Mvc;

namespace Form_Required_Validation.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Employee e)
        {
            return View();
        }
    }
}