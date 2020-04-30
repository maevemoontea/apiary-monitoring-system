using System;
using System.Collections.Generic;
using System.Text;

namespace ApiaryMonitoringSystem.BLL.DTO
{
    public class BeeHiveDTO
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int? ApiaryId { get; set; }
        public ApiaryDTO Apiary { get; set; }
        public string QueenbeeBreed { get; set; }
        public int QueenbeeAge { get; set; }
        public int FamilyClass { get; set; }
        public string HiveType { get; set; }
        public string ImageFile { get; set; }
        public ICollection<HealthStatusDTO> HealthStatuses { get; set; }
        public ICollection<InspectionDTO> Inspections { get; set; }
    }
}
