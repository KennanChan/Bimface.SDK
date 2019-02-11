namespace Bimface.SDK.Interfaces.Infrastructure.Http
{
    public interface IHttpClient
    {
        IHttpResponse GetResponse(IHttpRequest request);
    }
}