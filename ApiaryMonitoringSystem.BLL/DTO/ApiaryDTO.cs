using System;
using System.Collections.Generic;
using System.Text;

namespace ApiaryMonitoringSystem.BLL.DTO
{
    public class ApiaryDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string CurrentAddress { get; set; }
        public string Beekeeper { get; set; }
        public ICollection<BeeHiveDTO> BeeHives { get; set; }
    }
}
