using Bimface.SDK.Entities.Parameters.Base;
using Bimface.SDK.Extensions;
using Bimface.SDK.Requests.Base;

namespace Bimface.SDK.Requests.Data.File
{
    public abstract class BimfaceFileDataApiRequest : BimfaceDataApiRequest
    {
        protected const string DefaultApiVersion = "v2";

        protected BimfaceFileDataApiRequest(FileParameter parameter, string method, string relativeApi, string apiVersion)
            : base(method, $"/files/{parameter.FileId}".CombinePath(relativeApi), apiVersion)
        {
        }

        protected BimfaceFileDataApiRequest(FileParameter parameter, string relativeApi, string apiVersion)
            : base($"/files/{parameter.FileId}".CombinePath(relativeApi), apiVersion)
        {
        }
    }
}