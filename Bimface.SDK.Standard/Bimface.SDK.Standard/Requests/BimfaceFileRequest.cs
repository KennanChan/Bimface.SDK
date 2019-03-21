namespace Bimface.SDK.Requests
{
    public abstract class BimfaceFileRequest : BimfaceRequest
    {
        private const string Host = "https://file.bimface.com";

        protected BimfaceFileRequest(string method, string api)
            : base(method, Host, api)
        {
        }

        protected virtual void Method()
        {

        }
    }
}