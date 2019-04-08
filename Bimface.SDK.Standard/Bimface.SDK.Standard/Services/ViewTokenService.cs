#region

using System.Threading.Tasks;
using Bimface.SDK.Entities.Parameters.View;
using Bimface.SDK.Interfaces.Core;

#endregion

namespace Bimface.SDK.Services
{
    internal class ViewTokenService : HttpService, IViewTokenService
    {
        #region Interface Implementations

        public Task<string> FetchViewToken(FetchCompareViewTokenParameter parameter)
        {
            return FetchAsync<string, FetchCompareViewTokenParameter>(parameter);
        }

        public Task<string> FetchViewToken(FetchFileViewTokenParameter parameter)
        {
            return FetchAsync<string, FetchFileViewTokenParameter>(parameter);
        }

        public Task<string> FetchViewToken(FetchIntegrateFileViewTokenParameter parameter)
        {
            return FetchAsync<string, FetchIntegrateFileViewTokenParameter>(parameter);
        }

        public Task<string> FetchViewToken(FetchIntegrateViewTokenParameter parameter)
        {
            return FetchAsync<string, FetchIntegrateViewTokenParameter>(parameter);
        }

        #endregion
    }
}