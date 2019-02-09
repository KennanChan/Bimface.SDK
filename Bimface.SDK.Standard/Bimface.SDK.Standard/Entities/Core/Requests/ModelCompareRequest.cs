using System;
namespace Bimface.SDK.Entities.Core
{
    public class ModelCompareRequest
    {
        public string Callback { get; set; }
        public string Name { get; set; }
        public int? Priority { get; set; }
        public string SourceId { get; set; }
        public ModelCompareItem[] Sources { get; set; }
    }
}
