namespace Bimface.SDK.Attributes.Http
{
    public class HttpMimeAttribute : HttpHeaderAttribute
    {
        #region Constructors

        public HttpMimeAttribute(string value) : base("Content-Type", value)
        {
        }

        #endregion
    }
}