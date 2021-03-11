using System.Threading.Tasks;

namespace PSIpgCSapi.Data
{
    public interface IPSIpgCSapiDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
