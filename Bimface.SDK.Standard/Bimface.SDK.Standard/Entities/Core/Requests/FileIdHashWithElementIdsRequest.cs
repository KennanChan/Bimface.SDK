namespace Bimface.SDK.Entities.Core.Requests
{
    public class FileIdHashWithElementIdsRequest
    {
        #region Properties

        public object[] ElementIds { get; set; }
        public string FileIdHash { get; set; }

        #endregion
    }
}