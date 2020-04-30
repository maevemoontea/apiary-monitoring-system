using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ApiaryMonitoringSystem.DAL.Entities;

namespace ApiaryMonitoringSystem.DAL.Configurations
{
    class HealthStatusConfigurations : IEntityTypeConfiguration<HealthStatus>
    {
        public void Configure(EntityTypeBuilder<HealthStatus> builder)
        {
            builder.ToTable("Health_statuses").HasKey(p => p.Id);
        }
    }
}
