#region

using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.OfflineDatabag
{
    [BimfaceApiHttpRequest(HttpMethods.Get, "/files/{fileId}/offlineDatabag")]
    public class LookupFileOfflineDatabagParameter : FileParameter
    {
        #region Constructors

        public LookupFileOfflineDatabagParameter(long fileId) : base(fileId)
        {
        }

        #endregion
    }
}