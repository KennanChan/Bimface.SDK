namespace Bimface.SDK.Entities.Core.Requests.DSL.Clauses
{
    public class BoolAndClause : MultiClause
    {
        #region Constructors

        public BoolAndClause(params IClause[] clauses) : base(clauses)
        {
        }

        public BoolAndClause()
        {
        }

        #endregion

        #region Others

        public override string GetName()
        {
            return "boolAnd";
        }

        #endregion
    }
}