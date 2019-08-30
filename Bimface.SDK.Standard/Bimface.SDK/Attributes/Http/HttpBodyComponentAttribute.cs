using Bimface.SDK.Entities.Http;

namespace Bimface.SDK.Attributes.Http
{
    public class HttpBodyComponentAttribute : HttpComponentAttribute
    {
        public HttpBodyComponentAttribute(HttpContentType contentType = HttpContentType.Json)
        {
            ContentType = contentType;
        }

        public HttpContentType ContentType { get; }
    }
}