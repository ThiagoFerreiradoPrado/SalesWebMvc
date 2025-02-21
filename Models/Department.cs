using System;
using System.Security.Cryptography;
using System.Collections.Generic;

namespace SalesWebMvc.Models 
    {
    public class Department 
        {
        public int Id { get; internal set; }
        public string Name { get; internal set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department() { }

        public Department(int id, string name) {
            Id = id;
            Name = name;
        }
        public void Add(Seller seller)
        {
            Sellers.Add(seller);
        }
        public double TotalSales(DateTime initial, DateTime final) 
        {
            return Sellers.Sum(seller => seller.TotalSales(initial, final));
        }
    }
}
