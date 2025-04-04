using Microsoft.AspNetCore.Mvc;

namespace SalesWebMvc.Controllers {
    public class SalesRecordsContoller : Controller {
        public IActionResult Index() {
            return View();
        }
        public IActionResult SimpleSearch() {
            return View();
        }
        public IActionResult GroupingSearch() {
            return View();
        }
    }
}
