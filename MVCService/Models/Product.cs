using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCService.Models
{
    public class Product
    {
       public Product(string prodName,decimal pri,string desc)
        {
            ProductName = prodName;
            Price = pri;
            Description = desc;
        }

        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}