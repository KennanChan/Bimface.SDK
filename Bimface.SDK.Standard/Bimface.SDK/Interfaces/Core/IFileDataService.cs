#region

using System.Threading.Tasks;
using Bimface.SDK.Entities.Core.Responses;
using Bimface.SDK.Entities.Parameters.Data.File;

#endregion

namespace Bimface.SDK.Interfaces.Core
{
    public interface IFileDataService
    {
        #region Others

        Task<string> DeleteElementProperty(DeleteFileElementPropertiesParameter                parameter);
        Task<DrawingSheet[]> ListDrawingSheets(ListFileDrawingSheetsParameter                  parameter);
        Task<string[]> ListElementIds(ListFileElementIdsParameter                              parameter);
        Task<MaterialInfo[]> ListElementMaterials(ListFileElementMaterialsParameter            parameter);
        Task<Property[]> ListElementsProperties(ListFileElementsPropertiesParameter            parameter);
        Task<Area[]> ListFloorAreas(ListFileFloorAreasParameter                                parameter);
        Task<FileFloorsMapping[]> ListFloors(ListFileFloorMappingsParameter                    parameter);
        Task<Link[]> ListLinks(ListFileLinksParameter                                          parameter);
        Task<Room[]> ListRooms(ListFileRoomsParameter                                          parameter);
        Task<Area> LookupArea(LookupFileAreaParameter                                          parameter);
        Task<Tree> LookupCategoryTree(LookupFileCategoryTreeParameter                          parameter);
        Task<Property> LookupElementProperty(LookupFileElementPropertyParameter                parameter);
        Task<Property> LookupElementsCommonProperty(LookupFileElementsCommandPropertyParameter parameter);
        Task<Room> LookupRoom(LookupFileRoomParameter                                          parameter);
        Task<string> ModifyElementProperties(ModifyFileElementPropertiesParameter              parameter);

        #endregion
    }
}