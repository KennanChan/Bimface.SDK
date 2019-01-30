namespace Bimface.SDK.Interfaces.Infrastructure.Http
{
    public interface IHttpClient
    {
        IHttpResponse Request(IHttpRequest request);
    }
}