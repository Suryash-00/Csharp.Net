using Microsoft.AspNetCore.Mvc;

namespace UnderstandingActionMethods.Controllers
{
    public class CityController : Controller
    {
        public IActionResult Bengaluru()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Bengaluru(string name, string sex)
        {
            return View();
        }
    }
}
