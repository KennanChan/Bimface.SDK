namespace Bimface.SDK.Entities.Core.Requests.DSL.Queries
{
    public class DSLIntegrateQuery : DSLQuery
    {
        #region Constructors

        public DSLIntegrateQuery(string[] targetIds) : base("integrate", targetIds)
        {
        }

        #endregion
    }
}