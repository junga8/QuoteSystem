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
        public Quote Get(int id)
        {
           var quote = _quoteService.GetTaskByID(id);

            if(quote== null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            return quote; 
        }

        // POST: api/Quote
        public void Post([FromBody]Quote quote)
        {
            _quoteService.InsertTask(quote);
        }

        // PUT: api/Quote/5
        public void Put(int id, [FromBody]Quote value)
        {
            _quoteService.UpdateTask(id, value);
        }

        // DELETE: api/Quote/5
        public void Delete(int id)
        { 
            _quoteService.DeleteTask(id);
        }
    }
}
