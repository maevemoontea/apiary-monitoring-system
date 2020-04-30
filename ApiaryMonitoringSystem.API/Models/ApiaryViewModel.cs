using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiaryMonitoringSystem.API.Models
{
    public class ApiaryViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string CurrentAddress { get; set; }
        public string Beekeeper { get; set; }
    }
}
