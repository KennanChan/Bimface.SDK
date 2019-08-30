#region

using Bimface.SDK.Attributes;
using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.Databag
{
    [BimfaceAuth]
    [BimfaceDataApiHttpRequest("/databag/thumbnail")]
    public class LookupDatabagThumbnailParameter : FileParameter
    {
        #region Constructors

        public LookupDatabagThumbnailParameter(long fileId, int size) : base(fileId)
        {
            Size   = size;
            FileId = fileId;
        }

        #endregion

        #region Properties

        [HttpQueryComponent]
        public new long FileId { get; }

        [HttpQueryComponent]
        public int Size { get; }

        #endregion
    }
}