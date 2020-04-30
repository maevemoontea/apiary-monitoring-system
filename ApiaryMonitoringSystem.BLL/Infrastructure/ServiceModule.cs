using Ninject.Modules;
using ApiaryMonitoringSystem.DAL.Interfaces;
using ApiaryMonitoringSystem.DAL.Repositories;

namespace ApiaryMonitoringSystem.BLL.Infrastructure
{
    public class ServiceModule : NinjectModule
    {
        private string connectionString;
        public ServiceModule(string connection)
        {
            connectionString = connection;
        }
        public override void Load()
        {
            Bind<IUnitOfWork>().To<EFUnitOfWork>().WithConstructorArgument(connectionString);
        }
    }
}