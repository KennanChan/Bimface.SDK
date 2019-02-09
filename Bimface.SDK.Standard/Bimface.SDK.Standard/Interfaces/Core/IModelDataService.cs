using System.Collections.Generic;
using System.Threading.Tasks;
using Bimface.SDK.Entities.Core;
using Bimface.SDK.Entities.Parameters;

namespace Bimface.SDK.Interfaces.Core
{
    public interface IModelDataService
    {
        Task<List<MaterialInfo>> ListElementMaterials(ListElementMaterialsParameter parameter);
        Task<List<Property>> ListElementProperties(ListElementPropertiesParameter parameter);
        Task<Property> LookupElementProperty(LookupElementPropertyParameter parameter);
    }
}