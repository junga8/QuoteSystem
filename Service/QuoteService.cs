using DataAccess;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class QuoteService : IQuoteService
    {
        private IRepository<Quote> QuoteRepository;



        public QuoteService(IRepository<Quote> QuoteRepo)
        {

            QuoteRepository = QuoteRepo;

        }


        public void DeleteTask(long id)
        {
            Quote quote = GetTaskByID(id);
            QuoteRepository.Remove(quote);
            QuoteRepository.SaveChanges(); 


        } 

        public IEnumerable<Quote> GetAllTasks()
        {
            return QuoteRepository.GetAll();
        }

        public Quote GetTaskByID(long id)
        {
            return QuoteRepository.Get(id);
        }

        public void InsertTask(Quote quote)
        {
            QuoteRepository.Insert(quote);
            QuoteRepository.SaveChanges();
        }

  

        public void UpdateTask(long id, Quote quote)
        {
            QuoteRepository.Update(quote, id);
            QuoteRepository.SaveChanges();
            
        }
    }
}
