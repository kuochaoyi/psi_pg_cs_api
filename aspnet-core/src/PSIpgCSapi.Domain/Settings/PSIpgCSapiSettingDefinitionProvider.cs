using Volo.Abp.Settings;

namespace PSIpgCSapi.Settings
{
    public class PSIpgCSapiSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(PSIpgCSapiSettings.MySetting1));
        }
    }
}
