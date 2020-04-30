using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiaryMonitoringSystem.DAL.Entities
{
    [Table("Bee_hives")]
    public class BeeHive
    {
        [Column("hive_id")]
        [Required]
        public int Id { get; set; }

        [Column("hive_number")]
        [Required]
        public int Number { get; set; }
        [Column("apiary_id")]
        public int? ApiaryId { get; set; }
        public Apiary Apiary { get; set; }
        public string QueenbeeBreed { get; set; }
        public int QueenbeeAge { get; set; }
        public int FamilyClass { get; set; }
        public string HiveType { get; set; }
        public string ImageFile { get; set; }
        public ICollection<HealthStatus> HealthStatuses { get; set; }
        public ICollection<Inspection> Inspections { get; set; }
        public BeeHive()
        {
            HealthStatuses = new List<HealthStatus>();
            Inspections = new List<Inspection>();
        }
    }
}
