using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiaryMonitoringSystem.API.Models
{
    public class BeeHiveViewModel
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int? ApiaryId { get; set; }
        public string QueenbeeBreed { get; set; }
        public int QueenbeeAge { get; set; }
        public int FamilyClass { get; set; }
        public string HiveType { get; set; }
        public string ImageFile { get; set; }
    }
}
