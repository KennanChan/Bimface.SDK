﻿using Bimface.SDK.Entities.Parameters;

namespace Bimface.SDK.Requests.Data.File
{
    internal class ListFileViewsRequest : BimfaceFileDataApiRequest
    {
        #region Constructors

        public ListFileViewsRequest(ListFileViewsParameter parameter, string apiVersion = DefaultApiVersion)
            : base(parameter, "/views", apiVersion)
        {
        }

        #endregion
    }
}