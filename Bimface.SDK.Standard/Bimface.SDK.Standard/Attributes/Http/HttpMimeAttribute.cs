namespace Bimface.SDK.Attributes.Http
{
    public class HttpMimeAttribute : HttpHeaderAttribute
    {
        public HttpMimeAttribute(string value) : base("Content-Type", value)
        {

        }
    }
}
