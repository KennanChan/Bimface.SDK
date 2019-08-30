#region

using System.Threading.Tasks;
using Bimface.SDK.Entities.Core.Responses;
using Bimface.SDK.Entities.Parameters.Data.Databag;
using Bimface.SDK.Interfaces.Core;

#endregion

namespace Bimface.SDK.Services
{
    internal class DatabagDataService : HttpService, IDatabagDataService
    {
        #region Interface Implementations

        public Task<DatabagInfo> LookupLength(LookupDatabagLengthParameter parameter)
        {
            return FetchAsync<DatabagInfo, LookupDatabagLengthParameter>(parameter);
        }

        public Task<string> LookupThumbnail(LookupDatabagThumbnailParameter parameter)
        {
            return FetchAsync<string, LookupDatabagThumbnailParameter>(parameter);
        }

        #endregion
    }
}