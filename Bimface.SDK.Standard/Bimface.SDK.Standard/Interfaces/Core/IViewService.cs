#region

using System.Threading.Tasks;
using Bimface.SDK.Entities.Parameters.View;

#endregion

namespace Bimface.SDK.Interfaces.Core
{
    public interface IViewService
    {
        #region Others

        Task<string> FetchCompareViewToken(FetchCompareViewTokenParameter             parameter);
        Task<string> FetchFileViewToken(FetchFileViewTokenParameter                   parameter);
        Task<string> FetchIntegrateFileViewToken(FetchIntegrateFileViewTokenParameter parameter);
        Task<string> FetchIntegrateViewToken(FetchIntegrateViewTokenParameter         parameter);

        #endregion
    }
}