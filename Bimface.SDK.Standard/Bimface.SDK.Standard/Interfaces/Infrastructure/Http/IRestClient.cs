namespace Bimface.SDK.Interfaces.Infrastructure.Http
{
    public interface IHttpClient
    {
        #region Others

        IHttpResponse GetResponse(IHttpRequest request);

        #endregion
    }
}