namespace Bimface.SDK.Entities.Core.Requests.DSL.Queries
{
    public class DSLFileQuery : DSLQuery
    {
        #region Constructors

        public DSLFileQuery(string[] targetIds) : base("file", targetIds)
        {
        }

        #endregion
    }
}