namespace Bimface.SDK.Entities.Core.Requests
{
    public class TreeNodeSort
    {
        public NodeType NodeType     { get; set; }
        public string   SortBy       { get; set; }
        public string[] SortedValues { get; set; }
    }
}