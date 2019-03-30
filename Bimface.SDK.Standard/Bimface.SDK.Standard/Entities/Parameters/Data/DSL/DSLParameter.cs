#region

using Bimface.SDK.DSL;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.DSL
{
    public abstract class DSLParameter
    {
        #region Constructors

        protected DSLParameter(DSLQuery query)
        {
            Query = query;
        }

        #endregion

        #region Properties

        public DSLQuery Query { get; }

        #endregion
    }
}