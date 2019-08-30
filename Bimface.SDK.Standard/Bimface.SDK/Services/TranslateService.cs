#region

using System.Threading.Tasks;
using Bimface.SDK.Entities.Core.Responses;
using Bimface.SDK.Entities.Parameters.Translate;
using Bimface.SDK.Interfaces.Core;

#endregion

namespace Bimface.SDK.Services
{
    internal class TranslateService : HttpService, ITranslateService
    {
        #region Interface Implementations

        public Task<FileTranslateEntity> CreateTranslate(CreateTranslateParameter parameter)
        {
            return FetchAsync<FileTranslateEntity, CreateTranslateParameter>(parameter);
        }

        public Task<PagedList<FileTranslateDetailEntity>> ListTranslateDetails(ListTranslateDetailsParameter parameter)
        {
            return FetchAsync<PagedList<FileTranslateDetailEntity>, ListTranslateDetailsParameter>(parameter);
        }

        public Task<FileTranslateEntity> LookupTranslate(LookupTranslateParameter parameter)
        {
            return FetchAsync<FileTranslateEntity, LookupTranslateParameter>(parameter);
        }

        #endregion
    }
}