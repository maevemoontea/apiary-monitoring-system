using System;
using System.Collections.Generic;
using System.Linq;
using ApiaryMonitoringSystem.DAL.Entities;
using ApiaryMonitoringSystem.DAL.EF;
using ApiaryMonitoringSystem.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiaryMonitoringSystem.DAL.Repositories
{
    public class ApiaryRepository : IRepository<Apiary>
    {
        private ApiaryContext db;

        public ApiaryRepository(ApiaryContext context)
        {
            this.db = context;
        }

        public IEnumerable<Apiary> GetAll()
        {
            return db.Apiaries;
        }

        public Apiary Get(int id)
        {
            return db.Apiaries.Find(id);
        }

        public void Create(Apiary entity)
        {
            db.Apiaries.Add(entity);
        }

        public void Update(Apiary entity)
        {
            db.Entry(entity).State = EntityState.Modified;
        }

        public IEnumerable<Apiary> Find(Func<Apiary, Boolean> predicate)
        {
            return db.Apiaries.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            Apiary entity = db.Apiaries.Find(id);
            if (entity != null)
                db.Apiaries.Remove(entity);
        }
    }
}