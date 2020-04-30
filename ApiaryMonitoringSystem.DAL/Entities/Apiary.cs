using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiaryMonitoringSystem.DAL.Entities
{
    [Table("Apiaries")]
    public class Apiary
    {
        [Column("apiary_id")]
        [Required]
        public int Id { get; set; }

        [Column("apiary_title")]
        [Required]
        public string Title { get; set; }
        [Required]
        public string CurrentAddress { get; set; }
        [Required]
        public string Beekeeper { get; set; }
        public ICollection<BeeHive> BeeHives { get; set; }
        public Apiary()
        {
            BeeHives = new List<BeeHive>();
        }
    }
}
