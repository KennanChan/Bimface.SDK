#region

using Bimface.SDK.Entities.Http;
using Bimface.SDK.Extensions;

#endregion

namespace Bimface.SDK.Attributes.Http
{
    public class BimfaceDataApiHttpRequestAttribute : BimfaceApiHttpRequestAttribute
    {
        #region Fields

        private const string ApiVersion = "v2";

        #endregion

        #region Constructors

        public BimfaceDataApiHttpRequestAttribute(string api, string apiVersion = ApiVersion)
            : base(HttpMethods.Get, $"/data/{apiVersion ?? ""}".CombinePath(api))
        {
        }

        #endregion
    }
}