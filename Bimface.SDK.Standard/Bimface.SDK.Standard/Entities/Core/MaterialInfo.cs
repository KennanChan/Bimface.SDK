using System;
namespace Bimface.SDK.Entities.Core
{
    public class MaterialInfo
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public PropertyGroup[] Parameters { get; set; }
    }
}
