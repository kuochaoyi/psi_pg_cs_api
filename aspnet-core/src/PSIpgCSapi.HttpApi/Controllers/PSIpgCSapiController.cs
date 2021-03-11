using PSIpgCSapi.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace PSIpgCSapi.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class PSIpgCSapiController : AbpController
    {
        protected PSIpgCSapiController()
        {
            LocalizationResource = typeof(PSIpgCSapiResource);
        }
    }
}