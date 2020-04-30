using System;
using System.Collections.Generic;
using System.Linq;
using ApiaryMonitoringSystem.DAL.Entities;
using ApiaryMonitoringSystem.DAL.EF;
using ApiaryMonitoringSystem.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiaryMonitoringSystem.DAL.Repositories
{
    public class InspectionRepository : IRepository<Inspection>
    {
        private ApiaryContext db;

        public InspectionRepository(ApiaryContext context)
        {
            this.db = context;
        }

        public IEnumerable<Inspection> GetAll()
        {
            return db.Inspections;
        }

        public Inspection Get(int id)
        {
            return db.Inspections.Find(id);
        }

        public void Create(Inspection entity)
        {
            db.Inspections.Add(entity);
        }

        public void Update(Inspection entity)
        {
            db.Entry(entity).State = EntityState.Modified;
        }

        public IEnumerable<Inspection> Find(Func<Inspection, Boolean> predicate)
        {
            return db.Inspections.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            Inspection entity = db.Inspections.Find(id);
            if (entity != null)
                db.Inspections.Remove(entity);
        }
    }
}