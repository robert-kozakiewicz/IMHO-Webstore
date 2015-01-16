using ImhoWebstore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImhoWebstore.Repositories
{
    public class ProductRepository
    {
        public IEnumerable<Product> GetProducts()
        {
            return new List<Product>()
            {
                new Product(){ Name = "Stoicyzm", Category = new Category(){ Name = "Filozofia" } }
            };
        }
    }
}