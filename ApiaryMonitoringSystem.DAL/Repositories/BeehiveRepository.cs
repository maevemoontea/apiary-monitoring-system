using System;
using System.Collections.Generic;
using System.Linq;
using ApiaryMonitoringSystem.DAL.Entities;
using ApiaryMonitoringSystem.DAL.EF;
using ApiaryMonitoringSystem.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiaryMonitoringSystem.DAL.Repositories
{
    public class BeehiveRepository : IRepository<BeeHive>
    {
        private ApiaryContext db;

        public BeehiveRepository(ApiaryContext context)
        {
            this.db = context;
        }

        public IEnumerable<BeeHive> GetAll()
        {
            return db.BeeHives;
        }

        public BeeHive Get(int id)
        {
            return db.BeeHives.Find(id);
        }

        public void Create(BeeHive entity)
        {
            db.BeeHives.Add(entity);
        }

        public void Update(BeeHive entity)
        {
            db.Entry(entity).State = EntityState.Modified;
        }

        public IEnumerable<BeeHive> Find(Func<BeeHive, Boolean> predicate)
        {
            return db.BeeHives.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            BeeHive entity = db.BeeHives.Find(id);
            if (entity != null)
                db.BeeHives.Remove(entity);
        }
    }
}