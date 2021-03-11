using PSIpgCSapi.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace PSIpgCSapi.Permissions
{
    public class PSIpgCSapiPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(PSIpgCSapiPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(PSIpgCSapiPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<PSIpgCSapiResource>(name);
        }
    }
}
