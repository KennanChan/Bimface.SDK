#region

using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.File
{
    public class LookupFileAreaParameter : FileParameter
    {
        #region Constructors

        public LookupFileAreaParameter(long fileId, string areaId) : base(fileId)
        {
            AreaId = areaId;
        }

        #endregion

        #region Properties

        public string AreaId { get; }

        #endregion
    }
}