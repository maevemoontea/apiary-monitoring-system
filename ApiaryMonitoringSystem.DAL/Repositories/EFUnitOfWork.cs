using System;
using ApiaryMonitoringSystem.DAL.EF;
using ApiaryMonitoringSystem.DAL.Interfaces;
using ApiaryMonitoringSystem.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiaryMonitoringSystem.DAL.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private ApiaryContext db;
        private ApiaryRepository apiaryRepository;
        private BeehiveRepository beehiveRepository;
        private HealthStatusRepository healthStatusRepository;
        private InspectionRepository inspectionRepository;

        public EFUnitOfWork(string connectionString)
        {
            //Attention! I used IDesignTimeDbContextFactory<ApiaryContext> returned ApiaryContext(optionsBuilder.Options).
            //           I think thats why I can't create DbContext with connectionString. It looks like something
            //          not good enougth.
            var options = SqlServerDbContextOptionsExtensions.UseSqlServer(new DbContextOptionsBuilder<ApiaryContext>(), connectionString).Options;
            db = new ApiaryContext(options);
        }
        public IRepository<Apiary> Apiaries
        {
            get
            {
                if (apiaryRepository == null)
                    apiaryRepository = new ApiaryRepository(db);
                return apiaryRepository;
            }
        }

        public IRepository<BeeHive> BeeHives
        {
            get
            {
                if (beehiveRepository == null)
                    beehiveRepository = new BeehiveRepository(db);
                return beehiveRepository;
            }
        }
        public IRepository<HealthStatus> HealthStatuses
        {
            get
            {
                if (healthStatusRepository == null)
                    healthStatusRepository = new HealthStatusRepository(db);
                return healthStatusRepository;
            }
        }
        public IRepository<Inspection> Inspections
        {
            get
            {
                if (inspectionRepository == null)
                    inspectionRepository = new InspectionRepository(db);
                return inspectionRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}