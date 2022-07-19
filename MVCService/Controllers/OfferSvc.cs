using MVCService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace MVCService.Controllers
{
    public class OfferSvc : ApiController
    {
        public OfferService _objOffSvc;
        public OfferSvc(OfferService objOffSvc)
        {
            _objOffSvc = objOffSvc;
        }

        //public async Task<List<Offer>> Get()
        //{
        //   // await Task.Run(() => _objOffSvc.GetTodaysOffers());
        //    // _objOffSvc.GetTodaysOffers();
           
        //}

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}