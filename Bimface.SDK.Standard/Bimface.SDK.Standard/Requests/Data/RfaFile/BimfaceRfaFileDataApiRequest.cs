using Bimface.SDK.Attributes;
using Bimface.SDK.Entities.Parameters.Base;
using Bimface.SDK.Extensions;
using Bimface.SDK.Requests.Base;

namespace Bimface.SDK.Requests.Data.RfaFile
{
    [BimfaceAuth]
    internal abstract class BimfaceRfaFileDataApiRequest : BimfaceDataApiRequest
    {
        #region Fields

        protected const string DefaultApiVersion = "v2";

        #endregion

        protected BimfaceRfaFileDataApiRequest(FileParameter parameter, string relativeApi, string apiVersion)
            : base($"/rfaFiles/{parameter.FileId}".CombinePath(relativeApi), apiVersion)
        {
        }
    }
}