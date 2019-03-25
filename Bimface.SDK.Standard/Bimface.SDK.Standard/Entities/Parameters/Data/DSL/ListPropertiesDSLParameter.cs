using Bimface.SDK.DSL;

namespace Bimface.SDK.Entities.Parameters.Data.DSL
{
    public class ListPropertiesDSLParameter : DSLParameter
    {
        public ListPropertiesDSLParameter(DSLQuery query) : base(query)
        {
        }

        public bool?  IncludeOverrides { get; set; }
        public string Properties       { get; set; }
    }
}