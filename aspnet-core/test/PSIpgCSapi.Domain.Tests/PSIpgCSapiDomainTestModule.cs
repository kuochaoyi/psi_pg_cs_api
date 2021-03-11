using PSIpgCSapi.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace PSIpgCSapi
{
    [DependsOn(
        typeof(PSIpgCSapiEntityFrameworkCoreTestModule)
        )]
    public class PSIpgCSapiDomainTestModule : AbpModule
    {

    }
}