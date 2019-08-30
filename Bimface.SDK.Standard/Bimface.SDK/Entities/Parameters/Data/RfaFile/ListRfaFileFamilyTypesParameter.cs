#region

using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.RfaFile
{
    [BimfaceDataApiHttpRequest("/rfaFiles/{fileId}/familyTypeMetas")]
    public class ListRfaFileFamilyTypesParameter : FileParameter
    {
        #region Constructors

        public ListRfaFileFamilyTypesParameter(long fileId) : base(fileId)
        {
        }

        #endregion
    }
}