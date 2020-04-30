using ApiaryMonitoringSystem.DAL.Entities;
using System;

namespace ApiaryMonitoringSystem.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Apiary> Apiaries { get; }
        IRepository<BeeHive> BeeHives { get; }
        IRepository<HealthStatus> HealthStatuses { get; }
        IRepository<Inspection> Inspections { get; }
        void Save();
    }
}