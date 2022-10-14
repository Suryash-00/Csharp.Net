using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ViewImportsDemo.Models;

namespace ViewImportsDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Student std1 = new Student()
            {
                id = 1,
                name = "Suryash",
                age = 23
            };
            Student std2 = new Student()
            {
                id = 2,
                name = "Yash",
                age = 24
            };
            Student std3 = new Student()
            {
                id = 3,
                name = "Daksh",
                age = 22
            };
            Student std4 = new Student()
            {
                id = 3,
                name = "Piyush",
                age = 24
            };

            List<Student> std_list = new List<Student>();
            std_list.Add(std1);
            std_list.Add(std2);
            std_list.Add(std3);
            std_list.Add(std4);
            
            return View();
        }
    }
}