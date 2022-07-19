using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCService.Models
{
    public class Offer
    {
        public Offer(string offName, List<Product> lstprod)
        {
            OfferName = offName;
            if (lstprod != null && lstprod.Count > 0)
            {
                lstProducts = lstprod;
            }
            else
            {
                lstProducts = new List<Product>();
            }
            
        }

        public string OfferName { get; set; }
        public List<Product> lstProducts { get; set; }
       
    }
}