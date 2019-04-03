#region

using Bimface.SDK.Attributes;
using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.Databag
{
    [BimfaceAuth]
    [BimfaceApiHttpRequest(HttpMethods.Get, "/data/databag/length")]
    public class LookupDatabagLengthParameter : FileParameter
    {
        #region Constructors

        public LookupDatabagLengthParameter(long fileId) : base(fileId)
        {
            FileId = fileId;
        }

        [HttpQueryComponent]
        public new long FileId { get; }

        #endregion
    }
}