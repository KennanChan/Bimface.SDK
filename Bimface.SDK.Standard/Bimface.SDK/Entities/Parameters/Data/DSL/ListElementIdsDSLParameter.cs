#region

using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Core.Requests.DSL;
using Bimface.SDK.Entities.Core.Requests.DSL.Queries;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.DSL
{
    [BimfaceDataApiHttpRequest("/query/elementIds")]
    public class ListElementIdsDSLParameter : DSLParameter
    {
        #region Constructors

        public ListElementIdsDSLParameter(DSLQuery query) : base(query)
        {
        }

        #endregion

        #region Properties

        [HttpQueryComponent]
        public bool? IncludeOverrides { get; set; }

        #endregion
    }
}