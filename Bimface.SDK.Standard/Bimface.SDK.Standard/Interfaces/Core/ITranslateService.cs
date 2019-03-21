#region

using Bimface.SDK.Entities.Core;
using Bimface.SDK.Entities.Parameters.Translate;
using System.Threading.Tasks;

#endregion

namespace Bimface.SDK.Interfaces.Core
{
    public interface ITranslateService
    {
        Task<FileTranslateEntity> CreateTranslate(CreateTranslateParameter parameter);
        Task<FileTranslateEntity> LookupTranslate(LookupTranslateParameter parameter);
    }
}