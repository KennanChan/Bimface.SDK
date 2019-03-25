using Bimface.SDK.Attributes;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Requests.Base;

namespace Bimface.SDK.Requests.File
{
    [BimfaceAuth]
    internal class FetchSupportFileTypesRequest : BimfaceFileRequest
    {
        #region Constructors

        public FetchSupportFileTypesRequest() : base(HttpMethods.Get, "/support")
        {
        }

        #endregion
    }
}