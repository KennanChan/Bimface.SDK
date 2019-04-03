#region

using Bimface.SDK.Attributes.Http;
using Bimface.SDK.DSL;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.DSL
{
    [BimfaceDataApiHttpRequest("/query/areaIds")]
    public class ListAreaIdsDSLParameter : DSLParameter
    {
        #region Constructors

        public ListAreaIdsDSLParameter(DSLQuery query) : base(query)
        {
        }

        #endregion
    }
}