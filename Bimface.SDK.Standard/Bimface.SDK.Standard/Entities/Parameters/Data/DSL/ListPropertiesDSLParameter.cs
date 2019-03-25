using Bimface.SDK.DSL;

namespace Bimface.SDK.Entities.Parameters.Data.DSL
{
    public class ListPropertiesDSLParameter : DSLParameter
    {
        #region Constructors

        public ListPropertiesDSLParameter(DSLQuery query) : base(query)
        {
        }

        #endregion

        #region Properties

        public bool? IncludeOverrides { get; set; }
        public string Properties { get; set; }

        #endregion
    }
}