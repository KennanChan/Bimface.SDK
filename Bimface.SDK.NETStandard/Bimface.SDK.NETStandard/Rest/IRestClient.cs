namespace Bimface.SDK.NETStandard.Rest
{
    public interface IRestClient
    {
        IRestResponse Execute(IRestRequest request);
    }
}
