#region

using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Compare;
using Bimface.SDK.Requests.Base;

#endregion

namespace Bimface.SDK.Requests.Compare
{
    internal class DeleteCompareRequest : BimfaceCompareRequest
    {
        #region Constructors

        public DeleteCompareRequest(DeleteCompareParameter parameter, string apiVersion = DefaultApiVersion)
            : base(HttpMethods.Delete, "", apiVersion)
        {
            AddQuery("compareId", parameter.CompareId);
        }

        #endregion
    }
}