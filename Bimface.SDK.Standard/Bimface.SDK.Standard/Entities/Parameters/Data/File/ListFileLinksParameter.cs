#region

using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.File
{
    public class ListFileLinksParameter : FileParameter
    {
        public ListFileLinksParameter(long fileId) : base(fileId)
        {
        }
    }
}