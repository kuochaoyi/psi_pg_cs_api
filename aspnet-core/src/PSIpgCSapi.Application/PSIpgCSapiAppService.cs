using System;
using System.Collections.Generic;
using System.Text;
using PSIpgCSapi.Localization;
using Volo.Abp.Application.Services;

namespace PSIpgCSapi
{
    /* Inherit your application services from this class.
     */
    public abstract class PSIpgCSapiAppService : ApplicationService
    {
        protected PSIpgCSapiAppService()
        {
            LocalizationResource = typeof(PSIpgCSapiResource);
        }
    }
}
