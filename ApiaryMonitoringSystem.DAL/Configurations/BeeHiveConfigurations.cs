using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ApiaryMonitoringSystem.DAL.Entities;

namespace ApiaryMonitoringSystem.DAL.Configurations
{
    class BeeHiveConfigurations : IEntityTypeConfiguration<BeeHive>
    {
        public void Configure(EntityTypeBuilder<BeeHive> builder)
        {
            builder.ToTable("Bee_hives").HasKey(p => p.Id);
            builder.Property(p => p.Number).IsRequired().HasMaxLength(4);
        }
    }
}
