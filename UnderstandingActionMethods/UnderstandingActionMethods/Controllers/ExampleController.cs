using Microsoft.AspNetCore.Mvc;
using System;

namespace UnderstandingActionMethods.Controllers
{
    public class ExampleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ViewBagExample()
        {
            ViewBag.CurrentDateTime = DateTime.Now;
            ViewBag.CurrentYear = DateTime.Now.Year;
            return View();
        }
        public IActionResult TempDataExample()  //adds the current datetime and current year to 2 TempDate properties
        {
            TempData["CurrentDateTime"] = DateTime.Now;
            TempData["CurrentYear"] = DateTime.Now.Year;
            return RedirectToAction("TempDataShow");    //It then redirects the action method to the “TempDataShow” through RedirectToAction method
        }

        public IActionResult TempDataShow()
        {
            return View();
        }
    }
}
