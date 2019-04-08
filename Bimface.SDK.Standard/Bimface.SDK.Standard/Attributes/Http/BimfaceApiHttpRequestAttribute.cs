#region

using Bimface.SDK.Extensions;

#endregion

namespace Bimface.SDK.Attributes.Http
{
    public class BimfaceApiHttpRequestAttribute : HttpRequestAttribute
    {
        #region Fields

        private const string ApiHost = "https://api.bimface.com";

        #endregion

        #region Constructors

        public BimfaceApiHttpRequestAttribute(string method, string absoluteApi, string apiVersion = "")
            : base(method, ApiHost, $"/{apiVersion}".CombinePath(absoluteApi))
        {
        }

        #endregion
    }
}