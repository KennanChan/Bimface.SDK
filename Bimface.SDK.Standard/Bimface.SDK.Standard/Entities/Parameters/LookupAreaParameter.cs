namespace Bimface.SDK.Entities.Parameters
{
    public class LookupAreaParameter : FileParameter
    {
        #region Constructors

        public LookupAreaParameter(long? fileId, string areaId) : base(fileId)
        {
            AreaId = areaId;
        }

        #endregion

        #region Properties

        public string AreaId { get; }

        #endregion
    }
}