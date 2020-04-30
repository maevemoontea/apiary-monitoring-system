using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace ApiaryMonitoringSystem.DAL.EF
{
    //I use IDesignTimeDbContextFactory<TContext> for being able to run "Add-Migration" in Package Manager Console 
    public class ApiaryContextFactory : IDesignTimeDbContextFactory<ApiaryContext>
    {
        public ApiaryContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApiaryContext>();
            optionsBuilder.UseSqlServer("Data Source=blog.db");

            return new ApiaryContext(optionsBuilder.Options);
        }
    }
}