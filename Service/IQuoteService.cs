using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IQuoteService
    {

        IEnumerable<Quote> GetAllTasks();
        Quote GetTaskByID(long id);
        void InsertTask(Quote quote);

        void DeleteTask(long id);

        void UpdateTask(long id ,Quote quote);



      


    }
}
