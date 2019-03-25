﻿using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Compare;
using Bimface.SDK.Requests.Base;

namespace Bimface.SDK.Requests.Compare
{
    internal class DeleteCompareRequest : BimfaceCompareRequest
    {
        public DeleteCompareRequest(DeleteCompareParameter parameter, string apiVersion = DefaultApiVersion)
            : base(HttpMethods.Delete, "", apiVersion)
        {
            AddQuery("compareId", parameter.CompareId);
        }
    }
}
