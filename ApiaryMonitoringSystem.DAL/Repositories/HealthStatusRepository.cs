using System;
using System.Collections.Generic;
using System.Linq;
using ApiaryMonitoringSystem.DAL.Entities;
using ApiaryMonitoringSystem.DAL.EF;
using ApiaryMonitoringSystem.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiaryMonitoringSystem.DAL.Repositories
{
    public class HealthStatusRepository : IRepository<HealthStatus>
    {
        private ApiaryContext db;

        public HealthStatusRepository(ApiaryContext context)
        {
            this.db = context;
        }

        public IEnumerable<HealthStatus> GetAll()
        {
            return db.HealthStatuses;
        }

        public HealthStatus Get(int id)
        {
            return db.HealthStatuses.Find(id);
        }

        public void Create(HealthStatus entity)
        {
            db.HealthStatuses.Add(entity);
        }

        public void Update(HealthStatus entity)
        {
            db.Entry(entity).State = EntityState.Modified;
        }

        public IEnumerable<HealthStatus> Find(Func<HealthStatus, Boolean> predicate)
        {
            return db.HealthStatuses.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            HealthStatus entity = db.HealthStatuses.Find(id);
            if (entity != null)
                db.HealthStatuses.Remove(entity);
        }
    }
}