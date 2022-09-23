using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUDApp.Models;

namespace CRUDApp.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View(Repository.AllEmployees);
        }
        // HTTP GET VERSION
        public IActionResult Create()
        {
            return View();
        }

        // HTTP POST VERSION  
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                Repository.Create(employee);
                return View("Thanks", employee);
            }
            else
            {
                return View();
            }
        }
        public IActionResult Update(string empname)
        {
            Employee employee = Repository.AllEmployees.Where(e => e.Name == empname).FirstOrDefault();
            return View(employee);
        }
        [HttpPost]
        public IActionResult Update(Employee employee, string empname)
        {
            if (ModelState.IsValid)
            {
                Repository.AllEmployees.Where(e => e.Name == empname).FirstOrDefault().Age = employee.Age;
                Repository.AllEmployees.Where(e => e.Name == empname).FirstOrDefault().Salary = employee.Salary;
                Repository.AllEmployees.Where(e => e.Name == empname).FirstOrDefault().Department = employee.Department;
                Repository.AllEmployees.Where(e => e.Name == empname).FirstOrDefault().Sex = employee.Sex;
                Repository.AllEmployees.Where(e => e.Name == empname).FirstOrDefault().Name = employee.Name;

                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
        [HttpPost]
        public IActionResult Delete(string empname)
        {
            Employee employee = Repository.AllEmployees.Where(e => e.Name == empname).FirstOrDefault();
            Repository.Delete(employee);
            return RedirectToAction("Index");
        }
    }
}
