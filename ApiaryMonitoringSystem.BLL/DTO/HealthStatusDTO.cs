using System;
using System.Collections.Generic;
using System.Text;

namespace ApiaryMonitoringSystem.BLL.DTO
{
    public class HealthStatusDTO
    {
        public int Id { get; set; }
        public DateTime Timestamp { get; set; }
        public int? BeehiveId { get; set; }
        public BeeHiveDTO Beehive { get; set; }
        public int Temperature { get; set; }
        public int Humidity { get; set; }
        public int MaxIntensityFrequency { get; set; }
        public int IntensityOnLow { get; set; }
        public int IntensityOnMediate { get; set; }
        public int IntensityOnHigh { get; set; }
        public string SoundFile { get; set; }
    }
}
