using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PSIpgCSapi.Data;
using Volo.Abp.DependencyInjection;

namespace PSIpgCSapi.EntityFrameworkCore
{
    public class EntityFrameworkCorePSIpgCSapiDbSchemaMigrator
        : IPSIpgCSapiDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCorePSIpgCSapiDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the PSIpgCSapiMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<PSIpgCSapiMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}