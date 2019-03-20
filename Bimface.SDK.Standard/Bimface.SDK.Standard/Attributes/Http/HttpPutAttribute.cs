using System.Net;

namespace Bimface.SDK.Attributes.Http
{
    public class HttpPutAttribute : HttpMethodAttribute
    {
        public HttpPutAttribute() : base(WebRequestMethods.Http.Put)
        {
        }
    }
}
