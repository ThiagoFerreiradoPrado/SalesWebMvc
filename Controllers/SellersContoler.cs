﻿using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Services;
using SalesWebMvc.Models;
using SalesWebMvc.Models.ViewModels;

namespace SalesWebMvc.Controllers {
    public class SellersContoler : Controller {

        private readonly SellerService _sellerService;
        private readonly DepartmentService _departmentService;

        public SellersContoler(SellerService sellerService, DepartmentService departmentService) {
            _sellerService = sellerService;
            _departmentService = departmentService;
        }
        public IActionResult Index() {
            var list = _sellerService.FindAll();
            return View(list);
        }

        public IActionResult Create() { 
            var departments = _departmentService.FindAll();
            var viewModel = new SellerFormViewModel { Departments = departments };
            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Seller seller ) { 
            _sellerService.Insert(seller);
            return RedirectToAction(nameof(Index));

        }

        public IActionResult Delete(int? id) {
            if (id == null) {
                return NotFound();
            }
            var obj = _sellerService.FindById(id.Value);
            if (obj == null) {
                return NotFound();
            }
            return View(obj);
        }

        public IActionResult Details(int id) {
            if (id == null) {
                return NotFound();
            }
            var obj = _sellerService.FindById(id.Value);
            if (obj == null) {
                return NotFound();
            }
            return View(obj);
        }

    }
}
