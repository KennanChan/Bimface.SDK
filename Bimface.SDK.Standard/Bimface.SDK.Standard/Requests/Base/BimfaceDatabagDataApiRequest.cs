using Bimface.SDK.Extensions;

namespace Bimface.SDK.Requests.Base
{
    public abstract class BimfaceDatabagDataApiRequest : BimfaceDataApiRequest
    {
        #region Constructors

        protected BimfaceDatabagDataApiRequest(string method, string relativeApi, string apiVersion)
            : base(method, "/databag".CombinePath(relativeApi), apiVersion)
        {
        }

        #endregion
    }
}