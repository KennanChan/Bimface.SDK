using Bimface.SDK.Entities.Core;
using Bimface.SDK.Entities.Parameters;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bimface.SDK.Interfaces.Core
{
    public interface IModelDataService
    {
        Task<List<MaterialInfo>> ListElementMaterials(ListElementMaterialsParameter parameter);
        Task<List<Property>> ListElementProperties(ListElementPropertiesParameter parameter);
        Task<Property> LookupElementProperty(LookupElementPropertyParameter parameter);
        Task<List<Link>> ListLinkModels(ListLinkModelsParameter parameter);
        Task<Room> LookupRoom(LookupRoomParameter parameter);
        Task<List<AreaInfo>> ListFloorAreas(ListFloorAreasParameter parameter);
        Task<AreaInfo> LookupArea(LookupAreaParameter parameter);
    }
}