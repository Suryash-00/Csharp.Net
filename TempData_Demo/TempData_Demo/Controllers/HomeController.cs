using Microsoft.AspNetCore.Mvc;

namespace TempData_Demo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["var1"] = "Data from ViewData";
            ViewBag.var2 = "Data from ViewBag";
            TempData["var3"] = "Data from TempData";

            string[] arr = { "MS", "EC", "NXT", "DNA" };
            TempData["var4"]= arr;

            return View();
        }
        public IActionResult About()
        {
            TempData.Keep("var3");      //used to store data even after one redirection(will be available for third request)
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
    }
}
