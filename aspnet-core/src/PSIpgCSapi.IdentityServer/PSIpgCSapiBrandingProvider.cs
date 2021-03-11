using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace PSIpgCSapi
{
    [Dependency(ReplaceServices = true)]
    public class PSIpgCSapiBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "PSIpgCSapi";
    }
}
