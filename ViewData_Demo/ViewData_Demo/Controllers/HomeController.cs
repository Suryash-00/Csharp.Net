using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using ViewData_Demo.Models;

namespace ViewData_Demo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["var1"] = "Message came from ViewData";
            ViewData["var2"]= DateTime.Now.ToLongDateString();

            string[] suparr = { "Iron Man", "Spider Man", "Batman", "Daredevil" };
            ViewData["var3"]= suparr;

            ViewData["var4"] = new List<string>()
            {
                "Cricket",
                "Badminton",
                "Basketball"
            };

            Student Suri= new Student();
            Suri.Name = "Suryash Rastogi";
            Suri.Sex = "Male";
            Suri.Standard = 0;
            ViewData["var5"]= Suri;

            return View();
        }
    }
}
