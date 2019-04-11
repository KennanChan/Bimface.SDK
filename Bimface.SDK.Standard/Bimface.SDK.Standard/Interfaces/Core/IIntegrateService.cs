#region

using System.Threading.Tasks;
using Bimface.SDK.Entities.Core.Responses;
using Bimface.SDK.Entities.Parameters.Integrate;

#endregion

namespace Bimface.SDK.Interfaces.Core
{
    internal interface IIntegrateService
    {
        #region Others

        Task<FileIntegrateEntity> CreateIntegrate(CreateIntegrateParameter parameter);
        Task DeleteIntegrate(DeleteIntegrateParameter                      parameter);
        Task<FileIntegrateEntity> LookupIntegrate(LookupIntegrateParameter parameter);

        #endregion
    }
}