#region

using System.Collections.Generic;
using System.Threading.Tasks;
using Bimface.SDK.Entities.Core;
using Bimface.SDK.Entities.Parameters;

#endregion

namespace Bimface.SDK.Interfaces.Core
{
    public interface IModelDataService
    {
        Task<List<MaterialInfo>> ListElementMaterials(ListElementMaterialsParameter parameter);
        Task<List<Property>> ListElementProperties(ListElementPropertiesParameter parameter);
        Task<List<AreaInfo>> ListFloorAreas(ListFloorAreasParameter parameter);
        Task<List<Link>> ListLinkModels(ListLinkModelsParameter parameter);
        Task<AreaInfo> LookupArea(LookupAreaParameter parameter);
        Task<Property> LookupElementProperty(LookupElementPropertyParameter parameter);
        Task<Room> LookupRoom(LookupRoomParameter parameter);
    }
}