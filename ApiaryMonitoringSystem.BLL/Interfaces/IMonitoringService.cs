using ApiaryMonitoringSystem.BLL.DTO;
using System.Collections.Generic;

namespace ApiaryMonitoringSystem.BLL.Interfaces
{
    public interface IMonitoringService
    {
        ApiaryDTO GetApiary(int? id);
        BeeHiveDTO GetBeeHive(int? id);
        IEnumerable<BeeHiveDTO> GetBeeHives();
        void Dispose();
    }
}