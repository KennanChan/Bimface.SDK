﻿using Bimface.SDK.Entities.Parameters.Data.Integrate;

namespace Bimface.SDK.Requests.Data.Integrate
{
    internal class ListIntegrateAreasRequest : BimfaceIntegrateDataApiRequest
    {
        public ListIntegrateAreasRequest(ListIntegrateAreasParameter parameter, string apiVersion = DefaultApiVersion)
            : base(parameter, "/areas", apiVersion)
        {
            AddQuery("floorId", parameter.FloorId);
        }
    }
}
