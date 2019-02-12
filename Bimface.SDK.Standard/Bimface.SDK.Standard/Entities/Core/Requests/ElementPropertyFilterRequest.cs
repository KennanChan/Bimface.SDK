namespace Bimface.SDK.Entities.Core.Requests
{
    public class ElementPropertyFilterRequest
    {
        #region Properties

        public string[]           ElementIds { get; set; }
        public GroupAndKeysPair[] Filter     { get; set; }

        #endregion
    }
}