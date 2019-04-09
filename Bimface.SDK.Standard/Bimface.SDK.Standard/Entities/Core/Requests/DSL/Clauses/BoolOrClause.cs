namespace Bimface.SDK.Entities.Core.Requests.DSL.Clauses
{
    public class BoolOrClause : MultiClause
    {
        #region Fields

        private const string Id = "boolOr";

        #endregion

        #region Constructors

        public BoolOrClause(params IClause[] clauses) : base(clauses)
        {
        }

        public BoolOrClause()
        {
        }

        #endregion

        #region Others

        public override string GetName()
        {
            return Id;
        }

        #endregion
    }
}