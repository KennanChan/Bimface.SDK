#region

using Bimface.SDK.Attributes;
using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.File
{
    [BimfaceAuth]
    [BimfaceFileHttpRequest(HttpMethods.Get, "/metadata")]
    public class LookupFileParameter : HttpParameter
    {
        #region Constructors

        public LookupFileParameter(long fileId)
        {
            FileId = fileId;
        }

        #endregion

        [HttpQueryComponent(Alias = "fileId")]
        public long? FileId { get; }
    }
}