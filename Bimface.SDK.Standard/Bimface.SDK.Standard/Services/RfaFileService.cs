#region

using System.Collections.Generic;
using System.Threading.Tasks;
using Bimface.SDK.Entities.Core.Responses.Rfa;
using Bimface.SDK.Entities.Parameters.Data.RfaFile;
using Bimface.SDK.Interfaces.Core;

#endregion

namespace Bimface.SDK.Services
{
    internal class RfaFileService : HttpService, IRfaFileService
    {
        #region Interface Implementations

        public Task<List<string>> GetPropertyNames(ListRfaFilePropertyNamesParameter parameter)
        {
            return FetchAsync<List<string>, ListRfaFilePropertyNamesParameter>(parameter);
        }

        public Task<RfaFamilyTypeProperty> GetRfaFamilyTypeProperty(LookupRfaFileFamilyTypePropertyParameter parameter)
        {
            return FetchAsync<RfaFamilyTypeProperty, LookupRfaFileFamilyTypePropertyParameter>(parameter);
        }

        public Task<List<RfaFamilyType>> GetRfaFamilyTypes(ListRfaFileFamilyTypesParameter parameter)
        {
            return FetchAsync<List<RfaFamilyType>, ListRfaFileFamilyTypesParameter>(parameter);
        }

        #endregion
    }
}