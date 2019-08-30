namespace Bimface.SDK.Attributes.Http
{
    public class HttpBinaryMimeAttribute : HttpMimeAttribute
    {
        #region Constructors

        public HttpBinaryMimeAttribute() : base("application/octet-stream")
        {
        }

        #endregion
    }
}