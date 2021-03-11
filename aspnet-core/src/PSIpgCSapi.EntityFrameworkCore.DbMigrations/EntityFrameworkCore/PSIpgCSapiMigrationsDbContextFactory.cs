using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace PSIpgCSapi.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class PSIpgCSapiMigrationsDbContextFactory : IDesignTimeDbContextFactory<PSIpgCSapiMigrationsDbContext>
    {
        public PSIpgCSapiMigrationsDbContext CreateDbContext(string[] args)
        {
            PSIpgCSapiEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<PSIpgCSapiMigrationsDbContext>()
                .UseNpgsql(configuration.GetConnectionString("Default"));

            return new PSIpgCSapiMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../PSIpgCSapi.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
