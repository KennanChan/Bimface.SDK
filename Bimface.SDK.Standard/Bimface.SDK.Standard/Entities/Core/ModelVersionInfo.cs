using System.Collections.Generic;

namespace Bimface.SDK.Entities.Core
{
    public class ModelVersionInfo
    {
        public IDictionary<string, string> Config { get; set; }
        public string DatabagId { get; set; }
        public bool IsSupportComponentProperty { get; set; }
        public bool IsSupportDrawing { get; set; }
        public bool IsSupportFamilyTypeList { get; set; }
    }
}