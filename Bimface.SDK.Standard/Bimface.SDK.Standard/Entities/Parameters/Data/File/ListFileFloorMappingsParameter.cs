#region

using System.Collections.Generic;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.File
{
    public class ListFileFloorMappingsParameter
    {
        public ListFileFloorMappingsParameter()
        {
            FileIds = new List<long?>();
        }

        public List<long?> FileIds { get; set; }

        public bool? IncludeArea { get; set; }

        public bool? IncludeRoom { get; set; }
    }
}