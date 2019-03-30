﻿using Bimface.SDK.Entities.Parameters.Data.Integrate;

namespace Bimface.SDK.Requests.Data.Integrate
{
    internal class ListIntegrateFilesRequest : BimfaceIntegrateDataApiRequest
    {
        #region Constructors

        public ListIntegrateFilesRequest(ListIntegrateFilesParameter parameter, string apiVersion = DefaultApiVersion)
            : base(parameter, "/files", apiVersion)
        {
            AddNullableQuery("includeDrawingSheet", parameter.IncludeDrawingSheet);
        }

        #endregion
    }
}