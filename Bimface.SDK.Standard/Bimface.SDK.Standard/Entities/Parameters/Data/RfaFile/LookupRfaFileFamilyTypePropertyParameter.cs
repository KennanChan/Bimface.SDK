#region

using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.RfaFile
{
    [BimfaceDataApiHttpRequest("/rfaFiles/{fileId}/familyTypes/{familyTypeGuid}")]
    public class LookupRfaFileFamilyTypePropertyParameter : FileParameter
    {
        #region Constructors

        public LookupRfaFileFamilyTypePropertyParameter(long fileId, string familyTypeGuid) : base(fileId)
        {
            FamilyTypeGuid = familyTypeGuid;
        }

        #endregion

        #region Properties

        [HttpPathComponent]
        public string FamilyTypeGuid { get; }

        #endregion
    }
}