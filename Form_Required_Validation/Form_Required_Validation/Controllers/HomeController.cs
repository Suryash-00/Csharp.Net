using Form_Required_Validation.Models;
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
        
        /*public string Index(Employee e)
        {
            if (ModelState.IsValid)
            {
                return "Name is: " + e.Name + " Gender is: " + e.Gender + " Age is: " + e.Age;
            }
            else
            {
                return "Validation Failed";
            }
        }*/
    }
}