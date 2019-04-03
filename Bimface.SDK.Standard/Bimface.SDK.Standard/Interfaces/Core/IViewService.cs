using System.Threading.Tasks;
using Bimface.SDK.Entities.Parameters.View;

namespace Bimface.SDK.Interfaces.Core
{
    public interface IViewService
    {
        Task<string> FetchFileViewToken(FetchFileViewTokenParameter                   parameter);
        Task<string> FetchCompareViewToken(FetchCompareViewTokenParameter             parameter);
        Task<string> FetchIntegrateViewToken(FetchIntegrateViewTokenParameter         parameter);
        Task<string> FetchIntegrateFileViewToken(FetchIntegrateFileViewTokenParameter parameter);
    }
}
