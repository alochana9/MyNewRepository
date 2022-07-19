using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCService.Models
{
    public class OfferService
    {
        public OfferService()
        {
             AddInventory();
        }

        private List<Product> Inventory { get; set; }

        private void AddInventory()
        {
            Inventory = new List<Product>();

            Inventory.Add(new Product("P1", 1000, "P1 desc"));
            Inventory.Add(new Product("P2", 200, "P2 desc"));
            Inventory.Add(new Product("P3", 400, "P3 desc"));
            Inventory.Add(new Product("P4", 700, "P4 desc"));
            Inventory.Add(new Product("P5", 600, "P5 desc"));
            Inventory.Add(new Product("P6", 800, "P6 desc"));
        }

        public List<Product> GetAllProducts()
        {
            return Inventory;
        }

        public List<Offer> GetTodaysOffers()
        {
            List<Offer> lst = new List<Offer>();
            lst.Add(new Offer("ComboPackage1", Inventory.OrderBy(arg => Guid.NewGuid()).Take(3).ToList()));
            lst.Add(new Offer("ComboPackage2", Inventory.OrderBy(arg => Guid.NewGuid()).Take(3).ToList()));
            lst.Add(new Offer("ComboPackage3", Inventory.OrderBy(arg => Guid.NewGuid()).Take(3).ToList()));
            lst.Add(new Offer("ComboPackage4", Inventory.OrderBy(arg => Guid.NewGuid()).Take(3).ToList()));
            return lst;
        }
    }
    
}