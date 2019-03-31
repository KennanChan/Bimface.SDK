#region

using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.File;
using Bimface.SDK.Requests.Base;
using Bimface.SDK.Requests.Data.Databag;

#endregion

namespace Bimface.SDK.Requests.File
{
    internal class LookupFileOfflineDatabagDownloadUrlRequest : BimfaceDatabagDataApiRequest
    {
        #region Constructors

        public LookupFileOfflineDatabagDownloadUrlRequest(LookupFileOfflineDatabagDownloadUrlParameter parameter)
            : base(HttpMethods.Get, "/downloadUrl", "")
        {
            AddQuery("fileId", parameter.FileId);
            AddQuery("databagVersion", parameter.DatabagVersion);
            AddQuery("type", parameter.Type);
        }

        #endregion
    }
}