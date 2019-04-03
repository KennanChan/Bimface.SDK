namespace Bimface.SDK.Attributes.Http
{
    public class BimfaceFileHttpRequestAttribute : HttpRequestAttribute
    {
        #region Fields

        private const string FileHost = "https://file.bimface.com";

        #endregion

        #region Constructors

        public BimfaceFileHttpRequestAttribute(string method, string absoluteApi) : base(method, FileHost, absoluteApi)
        {
        }

        #endregion
    }
}