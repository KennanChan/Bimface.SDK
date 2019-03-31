#region

using Bimface.SDK.Extensions;
using Bimface.SDK.Requests.Base;

#endregion

namespace Bimface.SDK.Requests.Data.Databag
{
    public abstract class BimfaceDatabagDataApiRequest : BimfaceDataApiRequest
    {
        #region Fields

        protected const string DefaultApiVersion = "v2";

        #endregion
        #region Constructors

        protected BimfaceDatabagDataApiRequest(string method, string relativeApi, string apiVersion)
            : base(method, "/databag".CombinePath(relativeApi), apiVersion)
        {
        }

        #endregion
    }
}