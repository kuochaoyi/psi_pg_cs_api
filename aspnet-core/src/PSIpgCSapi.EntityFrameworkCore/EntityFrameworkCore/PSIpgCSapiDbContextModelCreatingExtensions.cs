using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace PSIpgCSapi.EntityFrameworkCore
{
    public static class PSIpgCSapiDbContextModelCreatingExtensions
    {
        public static void ConfigurePSIpgCSapi(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(PSIpgCSapiConsts.DbTablePrefix + "YourEntities", PSIpgCSapiConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}