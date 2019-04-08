#region

using System.Threading.Tasks;
using Bimface.SDK.Entities.Parameters.View;
using Bimface.SDK.Interfaces.Core;

#endregion

namespace Bimface.SDK.Services
{
    internal class ViewService : HttpService, IViewService
    {
        #region Interface Implementations

        public Task<string> FetchCompareViewToken(FetchCompareViewTokenParameter parameter)
        {
            return FetchAsync<string, FetchCompareViewTokenParameter>(parameter);
        }

        public Task<string> FetchFileViewToken(FetchFileViewTokenParameter parameter)
        {
            return FetchAsync<string, FetchFileViewTokenParameter>(parameter);
        }

        public Task<string> FetchIntegrateFileViewToken(FetchIntegrateFileViewTokenParameter parameter)
        {
            return FetchAsync<string, FetchIntegrateFileViewTokenParameter>(parameter);
        }

        public Task<string> FetchIntegrateViewToken(FetchIntegrateViewTokenParameter parameter)
        {
            return FetchAsync<string, FetchIntegrateViewTokenParameter>(parameter);
        }

        #endregion
    }
}