using System.Net;

namespace Bimface.SDK.Attributes.Http
{
    public class HttpPostAttribute : HttpMethodAttribute
    {
        public HttpPostAttribute() : base(WebRequestMethods.Http.Post)
        {
        }
    }
}
