#region

using Bimface.SDK.Attributes;
using Bimface.SDK.Attributes.Http;

#endregion

namespace Bimface.SDK.Entities.Parameters.Base
{
    [BimfaceAuth]
    public abstract class FileParameter : HttpParameter
    {
        #region Constructors

        protected FileParameter(long fileId)
        {
            FileId = fileId;
        }

        #endregion

        #region Properties

        [HttpPathComponent(Alias = "fileId")]
        public long? FileId { get; }

        #endregion
    }
}