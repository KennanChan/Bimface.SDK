#region

using System.Threading.Tasks;
using Bimface.SDK.Entities.Core.Responses;
using Bimface.SDK.Entities.Parameters.Data.File;
using Bimface.SDK.Interfaces.Core;

#endregion

namespace Bimface.SDK.Services
{
    internal class FileDataService : HttpService, IFileDataService
    {
        #region Interface Implementations

        public Task<string> DeleteElementProperty(DeleteFileElementPropertiesParameter parameter)
        {
            return FetchAsync<string, DeleteFileElementPropertiesParameter>(parameter);
        }

        public Task<DrawingSheet[]> ListDrawingSheets(ListFileDrawingSheetsParameter parameter)
        {
            return FetchAsync<DrawingSheet[], ListFileDrawingSheetsParameter>(parameter);
        }

        public Task<string[]> ListElementIds(ListFileElementIdsParameter parameter)
        {
            return FetchAsync<string[], ListFileElementIdsParameter>(parameter);
        }

        public Task<MaterialInfo[]> ListElementMaterials(ListFileElementMaterialsParameter parameter)
        {
            return FetchAsync<MaterialInfo[], ListFileElementMaterialsParameter>(parameter);
        }

        public Task<Property[]> ListElementsProperties(ListFileElementsPropertiesParameter parameter)
        {
            return FetchAsync<Property[], ListFileElementsPropertiesParameter>(parameter);
        }

        public Task<Area[]> ListFloorAreas(ListFileFloorAreasParameter parameter)
        {
            return FetchAsync<Area[], ListFileFloorAreasParameter>(parameter);
        }

        public Task<FileFloorsMapping[]> ListFloors(ListFileFloorMappingsParameter parameter)
        {
            return FetchAsync<FileFloorsMapping[], ListFileFloorMappingsParameter>(parameter);
        }

        public Task<Link[]> ListLinks(ListFileLinksParameter parameter)
        {
            return FetchAsync<Link[], ListFileLinksParameter>(parameter);
        }

        public Task<Room[]> ListRooms(ListFileRoomsParameter parameter)
        {
            return FetchAsync<Room[], ListFileRoomsParameter>(parameter);
        }

        public Task<Area> LookupArea(LookupFileAreaParameter parameter)
        {
            return FetchAsync<Area, LookupFileAreaParameter>(parameter);
        }

        public Task<Tree> LookupCategoryTree(LookupFileCategoryTreeParameter parameter)
        {
            return FetchAsync<Tree, LookupFileCategoryTreeParameter>(parameter);
        }

        public Task<Property> LookupElementProperty(LookupFileElementPropertyParameter parameter)
        {
            return FetchAsync<Property, LookupFileElementPropertyParameter>(parameter);
        }

        public Task<Room> LookupRoom(LookupFileRoomParameter parameter)
        {
            return FetchAsync<Room, LookupFileRoomParameter>(parameter);
        }

        public Task<string> ModifyElementProperties(ModifyFileElementPropertiesParameter parameter)
        {
            return FetchAsync<string, ModifyFileElementPropertiesParameter>(parameter);
        }

        #endregion
    }
}