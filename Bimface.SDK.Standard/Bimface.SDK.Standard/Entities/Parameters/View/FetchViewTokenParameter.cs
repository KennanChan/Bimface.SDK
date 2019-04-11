#region

using Bimface.SDK.Attributes;
using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.View
{
    [BimfaceAuth]
    [BimfaceApiHttpRequest(HttpMethods.Get, "/view/token")]
    public abstract class FetchViewTokenParameter : HttpParameter
    {
    }
}