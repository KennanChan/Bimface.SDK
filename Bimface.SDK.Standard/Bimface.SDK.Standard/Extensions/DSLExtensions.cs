#region

using Bimface.SDK.DSL.Clauses;

#endregion

namespace Bimface.SDK.Extensions
{
    public static class DSLExtensions
    {
        #region Others

        public static IClause And(this IClause clause, params IClause[] others)
        {
            return new BoolAndClause().AddClause(clause).AddClause(others);
        }

        public static IClause Or(this IClause clause, params IClause[] others)
        {
            return new BoolOrClause().AddClause(clause).AddClause(others);
        }

        #endregion
    }
}