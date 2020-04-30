using Microsoft.EntityFrameworkCore;
using ApiaryMonitoringSystem.DAL.Entities;
using ApiaryMonitoringSystem.DAL.Configurations;

namespace ApiaryMonitoringSystem.DAL.EF
{
    public class ApiaryContext : DbContext
    {
        public DbSet<Apiary> Apiaries { get; set; }
        public DbSet<BeeHive> BeeHives { get; set; }
        public DbSet<HealthStatus> HealthStatuses { get; set; }
        public DbSet<Inspection> Inspections { get; set; }
        public ApiaryContext(DbContextOptions<ApiaryContext> options)
            : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .ApplyConfiguration(new ApiaryConfigurations());
            builder
                .ApplyConfiguration(new BeeHiveConfigurations());
            builder
                .ApplyConfiguration(new HealthStatusConfigurations());
            builder
                .ApplyConfiguration(new InspectionConfigurations());
        }
    }
}
