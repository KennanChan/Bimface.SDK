namespace Bimface.SDK.Attributes.Http
{
    public class HttpBinaryMimeAttribute : HttpMimeAttribute
    {
        public HttpBinaryMimeAttribute() : base("application/octet-stream")
        {
        }
    }
}
