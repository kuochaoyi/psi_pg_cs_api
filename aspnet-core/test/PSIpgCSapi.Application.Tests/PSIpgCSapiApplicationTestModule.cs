using Volo.Abp.Modularity;

namespace PSIpgCSapi
{
    [DependsOn(
        typeof(PSIpgCSapiApplicationModule),
        typeof(PSIpgCSapiDomainTestModule)
        )]
    public class PSIpgCSapiApplicationTestModule : AbpModule
    {

    }
}