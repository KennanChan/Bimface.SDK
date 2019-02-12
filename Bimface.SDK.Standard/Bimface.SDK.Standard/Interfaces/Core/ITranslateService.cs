#region

using System.Threading.Tasks;
using Bimface.SDK.Entities.Core;
using Bimface.SDK.Entities.Parameters;

#endregion

namespace Bimface.SDK.Interfaces.Core
{
    public interface ITranslateService
    {
        Task<FileTranslateEntity> CreateTranslate(CreateTranslateParameter parameter);
        Task<FileTranslateEntity> LookupTranslate(LookupTranslateParameter parameter);
    }
}