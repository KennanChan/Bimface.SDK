#region

using Bimface.SDK.Attributes;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.File;
using Bimface.SDK.Requests.Base;

#endregion

namespace Bimface.SDK.Requests.File
{
    [BimfaceAuth]
    internal class LookupAppendFileRequest : BimfaceFileRequest
    {
        #region Constructors

        public LookupAppendFileRequest(LookupAppendFileParameter parameter) : base(HttpMethods.Get,
            $"/appendFiles/{parameter.AppendFileId}")
        {
        }

        #endregion
    }
}