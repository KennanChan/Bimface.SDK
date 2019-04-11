#region

using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.File
{
    [BimfaceDataApiHttpRequest("/files/{fileId}/views")]
    public class ListFileViewsParameter : FileParameter
    {
        #region Constructors

        public ListFileViewsParameter(long fileId) : base(fileId)
        {
        }

        #endregion
    }
}