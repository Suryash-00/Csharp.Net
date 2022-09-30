using Configuration.Services;
using Microsoft.AspNetCore.Mvc;

namespace Configuration.Controllers
{
    public class HomeController : Controller
    {
        private TotalUsers totalUsers;
        public HomeController(TotalUsers tu)
        {
            totalUsers = tu;
        }

        public string Index()
        {
            return "Total Users are: " + totalUsers.TUsers();
        }
        public IActionResult Exception()
        {
            throw new System.NullReferenceException();
        }
        public IActionResult Error()
        {
            return View();
        }
    }
}