namespace Bimface.SDK.Requests
{
    public abstract class BimfaceApiRequest : BimfaceRequest
    {
        private const string Host = "https://api.bimface.com";

        protected BimfaceApiRequest(string api, string method) : base(Host, api, method)
        {
        }

        protected BimfaceApiRequest(string api) : base(Host, api)
        {
        }
    }
}