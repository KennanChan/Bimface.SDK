#region

using System.Collections.Generic;
using System.Threading.Tasks;
using Bimface.SDK.Entities.Core.Rfa;
using Bimface.SDK.Entities.Parameters.Data.RfaFile;

#endregion

namespace Bimface.SDK.Interfaces.Core
{
    public interface IRfaFileService
    {
        #region Others

        Task<List<string>> GetPropertyNames(ListRfaFilePropertyNamesParameter                         parameter);
        Task<RfaFamilyTypeProperty> GetRfaFamilyTypeProperty(LookupRfaFileFamilyTypePropertyParameter parameter);
        Task<List<RfaFamilyType>> GetRfaFamilyTypes(ListRfaFileFamilyTypesParameter                   parameter);

        #endregion
    }
}