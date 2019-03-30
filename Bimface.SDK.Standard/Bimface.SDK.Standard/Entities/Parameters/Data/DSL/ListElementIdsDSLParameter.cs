#region

using Bimface.SDK.DSL;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.DSL
{
    public class ListElementIdsDSLParameter : DSLParameter
    {
        #region Constructors

        public ListElementIdsDSLParameter(DSLQuery query) : base(query)
        {
        }

        #endregion

        #region Properties

        public bool? IncludeOverrides { get; set; }

        #endregion
    }
}