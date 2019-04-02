namespace Bimface.SDK.Attributes.Http
{
    public class BimfaceApiHttpRequestAttribute : HttpRequestAttribute
    {
        #region Constructors

        public BimfaceApiHttpRequestAttribute(string method, string api) : base(method, "https://api.bimface.com", api)
        {
        }

        #endregion
    }
}