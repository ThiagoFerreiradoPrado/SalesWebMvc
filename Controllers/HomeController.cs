using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using System.Diagnostics;
using SalesWebMvc.Models.ViewModers;

namespace SalesWebMvc.Controllers {
    public class HomeController : Controller {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger) {
            _logger = logger;
        }

        public IActionResult Index() {
            return View();
        }

        public IActionResult About() {
            ViewData["Message"] = "Salles Web MVC app from C# Course.";

            return View();
        }

        public IActionResult Contact() {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
