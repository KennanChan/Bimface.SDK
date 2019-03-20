namespace Bimface.SDK.Requests
{
    public abstract class BimfaceFileRequest : BimfaceRequest
    {
        private const string Host = "https://file.bimface.com";

        protected BimfaceFileRequest(string api, string method)
            : base(Host, api, method)
        {
        }

        protected BimfaceFileRequest(string api) : base(Host, api)
        {

        }

        protected virtual void Method()
        {

        }
    }
}