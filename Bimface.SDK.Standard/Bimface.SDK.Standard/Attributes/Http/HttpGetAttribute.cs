using System.Net;

namespace Bimface.SDK.Attributes.Http
{
    public class HttpGetAttribute : HttpMethodAttribute
    {
        public HttpGetAttribute() : base(WebRequestMethods.Http.Get)
        {
        }
    }
}
