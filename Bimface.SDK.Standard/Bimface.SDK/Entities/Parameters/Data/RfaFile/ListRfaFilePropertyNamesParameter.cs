#region

using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.RfaFile
{
    [BimfaceDataApiHttpRequest("/rfaFiles/{fileId}/propertyNames")]
    public class ListRfaFilePropertyNamesParameter : FileParameter
    {
        #region Constructors

        public ListRfaFilePropertyNamesParameter(long fileId) : base(fileId)
        {
        }

        #endregion
    }
}