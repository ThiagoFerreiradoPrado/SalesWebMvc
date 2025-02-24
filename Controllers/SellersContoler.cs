using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Services;

namespace SalesWebMvc.Controllers {
    public class SellersContoler : Controller {

        private readonly SellerService _sellerService;

        public SellersContoler(SellerService sellerService) {
            _sellerService = sellerService;
        }
        public IActionResult Index() {
            var list = _sellerService.FindAll();
            return View(list);
        }


    }
}
