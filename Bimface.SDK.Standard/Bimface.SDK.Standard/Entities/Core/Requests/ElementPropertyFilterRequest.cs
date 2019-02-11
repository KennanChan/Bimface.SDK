namespace Bimface.SDK.Entities.Core.Requests
{
    public class ElementPropertyFilterRequest
    {
        public string[] ElementIds { get; set; }
        public GroupAndKeysPair[] Filter { get; set; }
    }
}