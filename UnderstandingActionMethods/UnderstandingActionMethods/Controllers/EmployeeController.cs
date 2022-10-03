using Microsoft.AspNetCore.Mvc;
using UnderstandingActionMethods.Models;

namespace UnderstandingActionMethods.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Index(int id, string name)
        {
            string welcomeMessage = $"Welcome Employee: {name} with id: {id}";
            return View((object)welcomeMessage);    //to pass string messages to a view we need to cast them to object type
        }
        public IActionResult Detail()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Detail(int id, string name)
        {
            Employee emp = new Employee();
            emp.Id = id;
            emp.Name = name;
            emp.Salary = 1000;
            emp.Designation = "Manager";
            emp.Address = "New York";
            return View(emp);
        }
    }
}
