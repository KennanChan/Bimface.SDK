using System.Threading.Tasks;
using Bimface.SDK.Entities.Core.Responses;
using Bimface.SDK.Entities.Parameters.Data.Databag;

namespace Bimface.SDK.Interfaces.Core
{
    public interface IDatabagDataService
    {
        Task<DatabagInfo> LookupLength(LookupDatabagLengthParameter  parameter);
        Task<string> LookupThumbnail(LookupDatabagThumbnailParameter parameter);
    }
}
