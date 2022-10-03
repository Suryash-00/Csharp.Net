using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using UnderstandingController.Models;

namespace UnderstandingController.Controllers
{
    public class HomeController : Controller
    {
        private IWebHostEnvironment hostingEnvironment;
        public HomeController(IWebHostEnvironment environment)
        {
            hostingEnvironment = environment;
        }

        [HttpPost]
        public async Task<IActionResult> Index(IFormFile photo)
        {
            // code to save the uploaded file in wwwroot folder
            using (var stream = new FileStream(Path.Combine(hostingEnvironment.WebRootPath, photo.FileName), FileMode.Create))
            {
                await photo.CopyToAsync(stream);
            }

            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ReceivedDataByRequest()
        {
            string name = Request.Form["name"];
            string sex = Request.Form["sex"];
            return View("ReceivedDataByRequest", $"{name} sex is {sex}");
        }
        public IActionResult ReceivedDataByParameter(string name, string sex)
        {
            return View("ReceivedDataByParameter", $"{name} sex is {sex}");
        }
        public IActionResult ReceivedDataByModelBinding(Person person)
        {
            return View("RecievedDataByModelBinding", person);
        }
    }
}