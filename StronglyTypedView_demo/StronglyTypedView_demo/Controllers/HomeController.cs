using Microsoft.AspNetCore.Mvc;
using StronglyTypedView_demo.Models;
using System.Collections.Generic;

namespace StronglyTypedView_demo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Employee emp1 = new Employee();
            emp1.Name = "Suryash Rastogi";
            emp1.Sex = "Male";
            emp1.Designation = "Intern";

            Employee emp2 = new Employee();
            emp2.Name = "Daksh Shukla";
            emp2.Sex = "Male";
            emp2.Designation = "Freelancer";

            Employee emp3 = new Employee();
            emp3.Name = "Yash Chaurasia";
            emp3.Sex = "Male";
            emp3.Designation = "Aspirant";

            List<Employee> myList = new List<Employee>();
            myList.Add(emp1);
            myList.Add(emp2);
            myList.Add(emp3);

            return View(myList);
        }
    }
}
