using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiaryMonitoringSystem.DAL.Entities
{
    [Table("Health_statuses")]
    public class HealthStatus
    {
        [Column("health_status_id")]
        [Required]
        public int Id { get; set; }
        public DateTime Timestamp { get; set; }
        [Column("hive_id")]
        [Required]
        public int? BeehiveId { get; set; }
        public BeeHive Beehive { get; set; }
        public int Temperature { get; set; }
        public int Humidity { get; set; }
        public int MaxIntensityFrequency { get; set; }
        public int IntensityOnLow { get; set; }
        public int IntensityOnMediate { get; set; }
        public int IntensityOnHigh { get; set; }
        public string SoundFile { get; set; }
    }
}
