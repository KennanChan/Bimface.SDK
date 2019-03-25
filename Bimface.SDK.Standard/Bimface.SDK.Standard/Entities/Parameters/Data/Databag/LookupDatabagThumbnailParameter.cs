using Bimface.SDK.Entities.Parameters.Base;

namespace Bimface.SDK.Entities.Parameters.Data.Databag
{
    public class LookupDatabagThumbnailParameter : FileParameter
    {
        public LookupDatabagThumbnailParameter(long fileId, int size) : base(fileId)
        {
            Size = size;
        }

        public int Size { get; }
    }
}
