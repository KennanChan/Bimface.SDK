using Bimface.SDK.DSL;

namespace Bimface.SDK.Entities.Parameters.Data.DSL
{
    public abstract class DSLParameter
    {
        protected DSLParameter(DSLQuery query)
        {
            Query = query;
        }

        public DSLQuery Query { get; }
    }
}