#region

using System.Threading.Tasks;
using Bimface.SDK.Entities.Core.Responses;
using Bimface.SDK.Entities.Parameters.Translate;

#endregion

namespace Bimface.SDK.Interfaces.Core
{
    public interface ITranslateService
    {
        #region Others

        Task<FileTranslateEntity> CreateTranslate(CreateTranslateParameter parameter);
        Task<FileTranslateEntity> LookupTranslate(LookupTranslateParameter parameter);

        #endregion
    }
}