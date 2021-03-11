using PSIpgCSapi.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace PSIpgCSapi.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(PSIpgCSapiEntityFrameworkCoreDbMigrationsModule),
        typeof(PSIpgCSapiApplicationContractsModule)
        )]
    public class PSIpgCSapiDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
