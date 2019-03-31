using Bimface.SDK.Entities.Parameters.Data.RfaFile;

namespace Bimface.SDK.Requests.Data.RfaFile
{
    internal class LookupRfaFileFamilyTypePropertyRequest : BimfaceRfaFileDataApiRequest
    {
        public LookupRfaFileFamilyTypePropertyRequest(LookupRfaFileFamilyTypePropertyParameter parameter, string apiVersion = DefaultApiVersion)
            : base(parameter, $"/familyTypes/{parameter.FamilyTypeGuid}", apiVersion)
        {
        }
    }
}
