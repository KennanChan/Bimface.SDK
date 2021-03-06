﻿#region

using Bimface.SDK.Attributes;
using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.File
{
    [BimfaceFileHttpRequest(HttpMethods.Get, "/download/url")]
    [BimfaceAuth]
    public class FileDownloadAddressParameter : HttpParameter
    {
        #region Constructors

        public FileDownloadAddressParameter(long fileId)
        {
            FileId = fileId;
        }

        #endregion

        #region Properties

        [HttpQueryComponent]
        public long FileId { get; }

        [HttpQueryComponent]
        public string Name { get; set; }

        #endregion
    }
}