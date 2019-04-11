#region

using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Core.Requests.DSL;
using Bimface.SDK.Entities.Core.Requests.DSL.Queries;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.DSL
{
    [BimfaceDataApiHttpRequest("/query/propertyValues")]
    public class ListPropertiesDSLParameter : DSLParameter
    {
        #region Constructors

        public ListPropertiesDSLParameter(DSLQuery query) : base(query)
        {
        }

        #endregion

        #region Properties

        [HttpQueryComponent]
        public bool? IncludeOverrides { get; set; }

        #endregion
    }
}