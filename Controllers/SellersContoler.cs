﻿using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Services;
using SalesWebMvc.Models;

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

        public IActionResult Create() { 
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Seller seller ) { 
            _sellerService.Insert(seller);
            return RedirectToAction(nameof(Index));

        }

    }
}
