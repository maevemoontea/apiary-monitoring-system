using Ninject.Modules;
using ApiaryMonitoringSystem.BLL.Services;
using ApiaryMonitoringSystem.BLL.Interfaces;

namespace ApiaryMonitoringSystem.API.Util
{
    public class ApiaryModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IMonitoringService>().To<ApiaryMonitoringService>();
        }
    }
}