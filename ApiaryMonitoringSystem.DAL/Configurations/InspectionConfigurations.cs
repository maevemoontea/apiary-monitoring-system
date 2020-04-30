using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ApiaryMonitoringSystem.DAL.Entities;

namespace ApiaryMonitoringSystem.DAL.Configurations
{
    class InspectionConfigurations : IEntityTypeConfiguration<Inspection>
    {
        public void Configure(EntityTypeBuilder<Inspection> builder)
        {
            builder.ToTable("Inspections").HasKey(p => p.Id);
        }
    }
}
