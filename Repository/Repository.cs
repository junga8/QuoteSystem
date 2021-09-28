﻿using DataAccess;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly QuoteDBEntities context;
        private DbSet<T> entities;
       // string errorMessage = string.Empty;

        public Repository(QuoteDBEntities context)
        {
            this.context = context;
            entities = context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }

        public T Get(long id)
        {
            return entities.Find(id);
        }
        public void Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
            context.SaveChanges();
        }

     

        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            context.SaveChanges();
        }
        public void Remove(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public void Update(T entity, long id)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            else
            {
                using (QuoteDBEntities db = new QuoteDBEntities())
                {
                    var item = db.Quotes.FirstOrDefault(q => q.QuoteID == id); 

                    while (item.QuoteID == id)
                    {
                        entities.Attach(entity);
                        context.Entry(entity).State = EntityState.Modified;
                        context.SaveChanges();

                    }
                }
                

              


           


            }
        }
           
        }
    }



