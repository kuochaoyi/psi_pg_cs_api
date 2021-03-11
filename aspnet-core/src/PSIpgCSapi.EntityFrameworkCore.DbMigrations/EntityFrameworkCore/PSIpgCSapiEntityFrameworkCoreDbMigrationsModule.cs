using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace PSIpgCSapi.EntityFrameworkCore
{
    [DependsOn(
        typeof(PSIpgCSapiEntityFrameworkCoreModule)
        )]
    public class PSIpgCSapiEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<PSIpgCSapiMigrationsDbContext>();
        }
    }
}
