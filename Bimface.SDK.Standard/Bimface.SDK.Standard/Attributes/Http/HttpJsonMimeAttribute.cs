namespace Bimface.SDK.Attributes.Http
{
    public class HttpJsonMimeAttribute : HttpMimeAttribute
    {
        #region Constructors

        public HttpJsonMimeAttribute() : base("application/json")
        {
        }

        #endregion
    }
}