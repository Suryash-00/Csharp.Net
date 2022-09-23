using FirstAppMVC.Models;
using Microsoft.AspNetCore.Mvc;
using FirstAppMVC.Models;

namespace FirstAppMVC.Controllers
{
    public class FirstController : Controller
    {
        /*
        public string Index()    // Action method named 'Index'
        {
            return "Hello World";
        }
        public IActionResult Hello()
        {
            ViewBag.Message = "Hello MVC";
            return View();
        }
        */
        public IActionResult Info()
        {
            Person person= new Person();
            person.Name = "Suryash";
            person.Age = 23;
            person.Location = "Lucknow, UP";
            return View(person);
        }
    }
}
