using System;
using System.Threading.Tasks;
using Bimface.SDK.Entities.Core;
using Bimface.SDK.Entities.Parameters.Translate;
using Bimface.SDK.Interfaces.Core;

namespace Bimface.SDK.Services
{
    internal class TranslateService : HttpService, ITranslateService
    {
        public Task<FileTranslateEntity> CreateTranslate(CreateTranslateParameter parameter)
        {
            throw new NotImplementedException();
        }

        public Task<FileTranslateEntity> LookupTranslate(LookupTranslateParameter parameter)
        {
            throw new NotImplementedException();
        }
    }
}