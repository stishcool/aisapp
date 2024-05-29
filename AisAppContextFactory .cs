using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System.Configuration;

namespace aisapp
{
    public class AisAppContextFactory : IDesignTimeDbContextFactory<AisAppContext>
    {
        public AisAppContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AisAppContext>();
            var connectionString = ConfigurationManager.ConnectionStrings["AisAppContext"].ConnectionString;

            optionsBuilder.UseNpgsql(connectionString);

            return new AisAppContext(optionsBuilder.Options);
        }
    }
}
