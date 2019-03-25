using Bimface.SDK.DSL;

namespace Bimface.SDK.Entities.Parameters.Data.DSL
{
    public class ListElementIdsDSLParameter : DSLParameter
    {
        public ListElementIdsDSLParameter(DSLQuery query) : base(query)
        {
        }

        public bool? IncludeOverrides { get; set; }
    }
}