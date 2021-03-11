using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace PSIpgCSapi.Data
{
    /* This is used if database provider does't define
     * IPSIpgCSapiDbSchemaMigrator implementation.
     */
    public class NullPSIpgCSapiDbSchemaMigrator : IPSIpgCSapiDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}