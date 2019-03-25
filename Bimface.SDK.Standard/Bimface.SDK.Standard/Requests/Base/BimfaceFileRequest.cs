namespace Bimface.SDK.Requests.Base
{
    public abstract class BimfaceFileRequest : BimfaceRequest
    {
        #region Fields

        private const string Host = "https://file.bimface.com";

        #endregion

        #region Constructors

        protected BimfaceFileRequest(string method, string api)
            : base(method, Host, api)
        {
        }

        #endregion

        protected virtual void Method()
        {
        }
    }
}