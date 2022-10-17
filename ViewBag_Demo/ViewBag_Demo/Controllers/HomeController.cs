using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using ViewBag_Demo.Models;

namespace ViewBag_Demo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.var1 = "Data came from ViewBag";

            ViewBag.var2 = DateTime.Now.ToShortDateString();
            
            string[] arr = { "Suryash", "Yash", "Daksh" };
            ViewBag.var3 = arr;
            
            ViewBag.var4= new List<string>()
            {
                "Prototype",
                "Medal of Honour",
                "Mafia"
            };

            Employee Suri = new Employee();
            Suri.Name = "Suryash Rastogi";
            Suri.Designation = "Intern";
            Suri.City = "Lucknow";
            ViewBag.var5= Suri;

            return View();
        }
    }
}