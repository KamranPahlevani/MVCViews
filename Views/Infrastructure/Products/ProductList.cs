using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Views.Models;

namespace Views.Infrastructure.Products
{
    public class ProductList
    {
        public IEnumerable<Product> GetProductsList()
        {
            IEnumerable<Product> productList = new List<Product>(){
                new Product(){Name = "Kayak", Category="WaterSports", Price=34500m},
                new Product(){Name = "Lifejacket", Category="WaterSports", Price=67890m},
                new Product(){Name = "Soccer ball", Category="Football", Price=25000m},
                new Product(){Name = "Corner flags", Category="Football", Price=14444m},
                new Product(){Name = "Stadium", Category="WaterSports", Price=79500m},
                new Product(){Name = "Thinking cap", Category="Chess", Price=40000m}
            };
            return productList;
        }
    }
}