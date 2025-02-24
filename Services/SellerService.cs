using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SalesWebMvc.Data;
using SalesWebMvc.Models;
using System;
namespace SalesWebMvc.Services {
    public class SellerService {
        private readonly SalesWebMvcContext _context;

        public SellerService(SalesWebMvcContext context) {
            _context = context;
        }

        public List<Seller> FindAll() {
            return _context.Seller.ToList();
        }
    }
}
