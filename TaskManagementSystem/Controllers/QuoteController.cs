using DataAccess;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TaskManagementSystem.Controllers
{
    public class QuoteController : ApiController
    {
        private readonly IQuoteService _quoteService; 


        public QuoteController()
        {

        }
      
      

        //construction injection 
        public QuoteController(IQuoteService quoteService)
        {
            _quoteService = quoteService; 
                 

        }
        // GET: api/Quote
        public IEnumerable<Quote> Get()
        {
            return _quoteService.GetAllTasks().ToList();
        }

        // GET: api/Quote/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Quote
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Quote/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Quote/5
        public void Delete(int id)
        {
        }
    }
}
