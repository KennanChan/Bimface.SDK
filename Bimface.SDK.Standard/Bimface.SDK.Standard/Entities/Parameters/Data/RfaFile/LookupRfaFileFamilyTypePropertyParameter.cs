using Bimface.SDK.Entities.Parameters.Base;

namespace Bimface.SDK.Entities.Parameters.Data.RfaFile
{
    public class LookupRfaFileFamilyTypePropertyParameter : FileParameter
    {
        public LookupRfaFileFamilyTypePropertyParameter(long fileId, string familyTypeGuid) : base(fileId)
        {
            FamilyTypeGuid = familyTypeGuid;
        }

        public string FamilyTypeGuid { get; }
    }
}
