using Bimface.SDK.Entities.Parameters.Base;

namespace Bimface.SDK.Entities.Parameters.Data
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