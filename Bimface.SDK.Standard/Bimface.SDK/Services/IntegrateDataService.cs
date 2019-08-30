#region

using System.Threading.Tasks;
using Bimface.SDK.Entities.Core;
using Bimface.SDK.Entities.Core.Responses;
using Bimface.SDK.Entities.Parameters.Data.Integrate;
using Bimface.SDK.Interfaces.Core;

#endregion

namespace Bimface.SDK.Services
{
    internal class IntegrateDataService : HttpService, IIntegrateDataService
    {
        #region Interface Implementations

        public Task<string> DeleteFileElementProperties(DeleteIntegrateFileElementPropertyParameter parameter)
        {
            return FetchAsync<string, DeleteIntegrateFileElementPropertyParameter>(parameter);
        }

        public Task<Area[]> ListAreas(ListIntegrateAreasParameter parameter)
        {
            return FetchAsync<Area[], ListIntegrateAreasParameter>(parameter);
        }

        public Task<ElementsWithBoundingBox[]> ListElementIds(ListIntegrateElementIdsParameter parameter)
        {
            return FetchAsync<ElementsWithBoundingBox[], ListIntegrateElementIdsParameter>(parameter);
        }

        public Task<ElementIdWithBoundingBox[]> ListElementsBoundingBox(ListIntegrateElementsBoundingBoxParameter parameter)
        {
            return FetchAsync<ElementIdWithBoundingBox[], ListIntegrateElementsBoundingBoxParameter>(parameter);
        }

        public Task<Property[]> ListElementsProperties(ListIntegrateElementsPropertiesParameter parameter)
        {
            return FetchAsync<Property[], ListIntegrateElementsPropertiesParameter>(parameter);
        }

        public Task<MaterialInfo[]> ListFileElementMaterials(ListIntegrateFileElementMaterialsParameter parameter)
        {
            return FetchAsync<MaterialInfo[], ListIntegrateFileElementMaterialsParameter>(parameter);
        }

        public Task<IntegrateFileEntity[]> ListFiles(ListIntegrateFilesParameter parameter)
        {
            return FetchAsync<IntegrateFileEntity[], ListIntegrateFilesParameter>(parameter);
        }

        public Task<FileViews[]> ListFileViews(ListIntegrateFileViewsParameter parameter)
        {
            return FetchAsync<FileViews[], ListIntegrateFileViewsParameter>(parameter);
        }

        public Task<Floor[]> ListFloors(ListIntegrateFloorsParameter parameter)
        {
            return FetchAsync<Floor[], ListIntegrateFloorsParameter>(parameter);
        }

        public Task<Room[]> ListRooms(ListIntegrateRoomsParameter parameter)
        {
            return FetchAsync<Room[], ListIntegrateRoomsParameter>(parameter);
        }

        public Task<Area> LookupArea(LookupIntegrateAreaParameter parameter)
        {
            return FetchAsync<Area, LookupIntegrateAreaParameter>(parameter);
        }

        public Task<Tree> LookupCategoryTree(LookupIntegrateCategoryTreeParameter parameter)
        {
            return FetchAsync<Tree, LookupIntegrateCategoryTreeParameter>(parameter);
        }

        public Task<Property> LookupElementProperty(LookupIntegrateElementPropertyParameter parameter)
        {
            return FetchAsync<Property, LookupIntegrateElementPropertyParameter>(parameter);
        }

        public Task<Property> LookupElementsCommonProperty(LookupIntegrateElementsCommonPropertiesParameter parameter)
        {
            return FetchAsync<Property, LookupIntegrateElementsCommonPropertiesParameter>(parameter);
        }

        public Task<Property> LookupFileElementProperty(LookupIntegrateFileElementPropertyParameter parameter)
        {
            return FetchAsync<Property, LookupIntegrateFileElementPropertyParameter>(parameter);
        }

        public Task<Room> LookupRoom(LookupIntegrateRoomParameter parameter)
        {
            return FetchAsync<Room, LookupIntegrateRoomParameter>(parameter);
        }

        public Task<string> ModifyFileElementProperty(ModifyIntegrateFileElementPropertiesParameter parameter)
        {
            return FetchAsync<string, ModifyIntegrateFileElementPropertiesParameter>(parameter);
        }

        #endregion
    }
}