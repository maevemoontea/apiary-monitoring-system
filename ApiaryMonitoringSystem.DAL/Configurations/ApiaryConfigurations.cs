using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ApiaryMonitoringSystem.DAL.Entities;

namespace ApiaryMonitoringSystem.DAL.Configurations
{
    class ApiaryConfigurations : IEntityTypeConfiguration<Apiary>
    {
        public void Configure(EntityTypeBuilder<Apiary> builder)
        {
            builder.ToTable("Apiaries").HasKey(p => p.Id);
            builder.Property(p => p.Title).IsRequired().HasMaxLength(50);
        }
    }
}
