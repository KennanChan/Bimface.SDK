#region

using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.RfaFile
{
    public class LookupRfaFileFamilyTypePropertyParameter : FileParameter
    {
        #region Constructors

        public LookupRfaFileFamilyTypePropertyParameter(long fileId, string familyTypeGuid) : base(fileId)
        {
            FamilyTypeGuid = familyTypeGuid;
        }

        #endregion

        #region Properties

        public string FamilyTypeGuid { get; }

        #endregion
    }
}