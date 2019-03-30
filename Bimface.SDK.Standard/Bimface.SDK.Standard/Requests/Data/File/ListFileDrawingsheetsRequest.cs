﻿#region

using Bimface.SDK.Entities.Parameters.Data.File;

#endregion

namespace Bimface.SDK.Requests.Data.File
{
    internal class ListFileDrawingSheetsRequest : BimfaceFileDataApiRequest
    {
        #region Constructors

        public ListFileDrawingSheetsRequest(ListFileDrawingSheetsParameter parameter,
                                            string                         apiVersion = DefaultApiVersion)
            : base(parameter, "/drawingsheets", apiVersion)
        {
        }

        #endregion
    }
}