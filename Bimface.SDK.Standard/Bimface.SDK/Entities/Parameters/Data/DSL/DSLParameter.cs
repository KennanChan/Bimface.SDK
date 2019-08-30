#region

using Bimface.SDK.Attributes;
using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Core.Requests.DSL;
using Bimface.SDK.Entities.Core.Requests.DSL.Queries;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.DSL
{
    [BimfaceAuth]
    public abstract class DSLParameter : HttpParameter
    {
        #region Constructors

        protected DSLParameter(DSLQuery query)
        {
            Query = query;
        }

        #endregion

        #region Properties

        [HttpBodyComponent]
        public DSLQuery Query { get; }

        #endregion
    }
}