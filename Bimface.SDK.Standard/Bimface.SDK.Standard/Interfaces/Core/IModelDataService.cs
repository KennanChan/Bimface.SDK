#region

using Bimface.SDK.Entities.Core;
using Bimface.SDK.Entities.Parameters.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

#endregion

namespace Bimface.SDK.Interfaces.Core
{
    public interface IModelDataService
    {
        Task<List<MaterialInfo>> ListElementMaterials(ListFileElementMaterialsParameter parameter);
        Task<List<Property>> ListElementProperties(ListFileElementPropertiesParameter parameter);
        Task<List<AreaInfo>> ListFloorAreas(ListFileFloorAreasParameter parameter);
        Task<List<Link>> ListLinkModels(ListFileLinksParameter parameter);
        Task<AreaInfo> LookupArea(LookupFileAreaParameter parameter);
        Task<Property> LookupElementProperty(LookupElementPropertyParameter parameter);
        Task<Room> LookupRoom(LookupRoomParameter parameter);
    }
}