namespace Bimface.SDK.Attributes.Http
{
    public class BimfaceFileHttpRequestAttribute : HttpRequestAttribute
    {
        #region Constructors

        public BimfaceFileHttpRequestAttribute(string method, string api) : base(method, "https://file.bimface.com", api)
        {
        }

        #endregion
    }
}