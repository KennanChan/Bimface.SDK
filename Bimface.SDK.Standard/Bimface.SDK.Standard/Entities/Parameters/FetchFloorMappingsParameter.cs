using System.Collections.Generic;

namespace Bimface.SDK.Entities.Parameters
{
    public class FetchFloorMappingsParameter
    {
        public FetchFloorMappingsParameter()
        {
            FileIds = new List<long?>();
        }

        public List<long?> FileIds { get; set; }

        public bool? IncludeArea { get; set; }

        public bool? IncludeRoom { get; set; }
    }
}