using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Data.Databag;
using Bimface.SDK.Requests.Base;

namespace Bimface.SDK.Requests.Data.Databag
{
    internal class LookupDatabagThumbnailRequest : BimfaceDatabagDataApiRequest
    {
        #region Constructors

        public LookupDatabagThumbnailRequest(LookupDatabagThumbnailParameter parameter, string apiVersion = "v2")
            : base(HttpMethods.Get, "/thumbnail", apiVersion)
        {
        }

        #endregion
    }
}