namespace Bimface.SDK.Requests.Base
{
    public abstract class BimfaceApiRequest : BimfaceRequest
    {
        private const string Host = "https://api.bimface.com";

        protected BimfaceApiRequest(string method, string api) : base(method, Host, api)
        {
        }
    }
}