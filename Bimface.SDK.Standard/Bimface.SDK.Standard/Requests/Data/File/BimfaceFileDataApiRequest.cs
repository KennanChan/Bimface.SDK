﻿using Bimface.SDK.Entities.Parameters.Base;
using Bimface.SDK.Extensions;
using Bimface.SDK.Requests.Base;

namespace Bimface.SDK.Requests.Data.File
{
    public abstract class BimfaceFileDataApiRequest : BimfaceDataApiRequest
    {
        #region Fields

        protected const string DefaultApiVersion = "v2";

        #endregion

        #region Constructors

        protected BimfaceFileDataApiRequest(FileParameter parameter, string method, string relativeApi,
            string apiVersion)
            : base(method, $"/files/{parameter.FileId}".CombinePath(relativeApi),
                string.IsNullOrWhiteSpace(apiVersion) ? DefaultApiVersion : apiVersion)
        {
        }

        protected BimfaceFileDataApiRequest(FileParameter parameter, string relativeApi, string apiVersion)
            : base($"/files/{parameter.FileId}".CombinePath(relativeApi),
                string.IsNullOrWhiteSpace(apiVersion) ? DefaultApiVersion : apiVersion)
        {
        }

        #endregion
    }
}