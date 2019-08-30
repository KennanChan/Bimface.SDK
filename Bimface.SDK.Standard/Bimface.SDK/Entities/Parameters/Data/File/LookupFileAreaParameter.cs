#region

using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.File
{
    [BimfaceDataApiHttpRequest("/files/{fileId}/areas/{areaId}")]
    public class LookupFileAreaParameter : FileParameter
    {
        #region Constructors

        public LookupFileAreaParameter(long fileId, string areaId) : base(fileId)
        {
            AreaId = areaId;
        }

        #endregion

        #region Properties

        [HttpPathComponent]
        public string AreaId { get; }

        #endregion
    }
}