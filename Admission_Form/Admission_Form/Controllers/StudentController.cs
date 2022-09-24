using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admission_Form.Models;
using Microsoft.AspNetCore.Mvc;

namespace Admission_Form.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        // HTTP GET VERSION
        public IActionResult Create()
        {
            return View();
        }
        //HTTP POST VERSION
        [HttpPost]
        public IActionResult Create(Students students)
        {
            Student_Repository.Create(students);
            return View("Thanks", students);
        }
    }
}