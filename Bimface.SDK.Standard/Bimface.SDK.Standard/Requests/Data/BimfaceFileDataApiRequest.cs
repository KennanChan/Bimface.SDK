using Bimface.SDK.Entities.Parameters.Base;
using Bimface.SDK.Extensions;
using Bimface.SDK.Requests.Base;

namespace Bimface.SDK.Requests.Data
{
    public abstract class BimfaceFileDataApiRequest : BimfaceDataApiRequest
    {
        protected BimfaceFileDataApiRequest(FileParameter parameter, string method, string api, string version)
            : base(method, $"/files/{parameter.FileId}".CombinePath(api), version)
        {
        }

        protected BimfaceFileDataApiRequest(FileParameter parameter, string api, string version)
            : base($"/files/{parameter.FileId}".CombinePath(api), version)
        {
        }
    }
}