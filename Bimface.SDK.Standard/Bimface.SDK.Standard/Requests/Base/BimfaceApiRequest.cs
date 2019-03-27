namespace Bimface.SDK.Requests.Base
{
    /// <summary>
    ///     Base class for
    /// </summary>
    public abstract class BimfaceApiRequest : BimfaceRequest
    {
        #region Fields

        private const string Host = "https://api.bimface.com";

        #endregion

        #region Constructors

        protected BimfaceApiRequest(string method, string api) : base(method, Host, api)
        {
        }

        #endregion
    }
}