#region

using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.File
{
    [BimfaceDataApiHttpRequest("/files/{fileId}/links")]
    public class ListFileLinksParameter : FileParameter
    {
        #region Constructors

        public ListFileLinksParameter(long fileId) : base(fileId)
        {
        }

        #endregion
    }
}