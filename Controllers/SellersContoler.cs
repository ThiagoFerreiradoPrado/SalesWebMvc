using Microsoft.AspNetCore.Mvc;

namespace SalesWebMvc.Controllers {
    public class SellersContoler : Controller {
        public IActionResult Index() {

            return View();
        }
    }
}
