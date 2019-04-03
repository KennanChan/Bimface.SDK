#region

using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.File
{
    [BimfaceDataApiHttpRequest("/files/{fileId}/drawingsheets")]
    public class ListFileDrawingSheetsParameter : FileParameter
    {
        #region Constructors

        public ListFileDrawingSheetsParameter(long fileId) : base(fileId)
        {
        }

        #endregion
    }
}