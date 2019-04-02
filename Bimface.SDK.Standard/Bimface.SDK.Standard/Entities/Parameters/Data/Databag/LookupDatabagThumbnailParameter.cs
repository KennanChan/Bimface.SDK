#region

using Bimface.SDK.Attributes;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.Databag
{
    [BimfaceAuth]
    public class LookupDatabagThumbnailParameter : FileParameter
    {
        #region Constructors

        public LookupDatabagThumbnailParameter(long fileId, int size) : base(fileId)
        {
            Size = size;
        }

        #endregion

        #region Properties

        public int Size { get; }

        #endregion
    }
}