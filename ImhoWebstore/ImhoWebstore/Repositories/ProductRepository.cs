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
                new Product(){ 
                    Id = 1, 
                    Name = "Stoicyzm", 
                    Category =  "Filozofia",
                    ImageUrl = "stoicyzm.jpg",
                    Description = "Światopogląd filozoficzny ceniący dyscyplinę moralną oraz postulujący odcięcie się od zdarzeń zewnętrznych."
                },
                new Product(){ 
                    Id = 2, 
                    Name = "Korwinista", 
                    Category = "Polityka",
                    ImageUrl = "stoicyzm.jpg",
                    Description = "Pogląd "
                },
                new Product(){ 
                    Id = 3, 
                    Name = "Epikureizm", 
                    Category =  "Filozofia",
                    ImageUrl = "stoicyzm.jpg",
                    Description = "Światopogląd filozoficzny ceniący dyscyplinę moralną oraz postulujący odcięcie się od zdarzeń zewnętrznych."
                }
            };
        }
    }
}