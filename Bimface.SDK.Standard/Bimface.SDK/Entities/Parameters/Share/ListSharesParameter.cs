#region

using Bimface.SDK.Attributes;
using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Share
{
    [BimfaceAuth]
    [BimfaceApiHttpRequest(HttpMethods.Get, "/shares")]
    public class ListSharesParameter : HttpParameter
    {
    }
}