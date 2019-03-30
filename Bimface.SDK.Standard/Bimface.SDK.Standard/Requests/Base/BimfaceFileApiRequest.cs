#region

using Bimface.SDK.Attributes;
using Bimface.SDK.Entities.Parameters.Base;
using Bimface.SDK.Extensions;

#endregion

namespace Bimface.SDK.Requests.Base
{
    [BimfaceAuth]
    public abstract class BimfaceFileApiRequest : BimfaceApiRequest
    {
        #region Constructors

        protected BimfaceFileApiRequest(FileParameter parameter, string method, string relativeApi)
            : base(method, $"/files/{parameter.FileId}".CombinePath(relativeApi))
        {
        }

        #endregion
    }
}