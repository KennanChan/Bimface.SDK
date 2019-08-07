#region

using System.Threading.Tasks;
using Bimface.SDK.Entities.Core;
using Bimface.SDK.Entities.Core.Responses;
using Bimface.SDK.Entities.Parameters.Data.Integrate;

#endregion

namespace Bimface.SDK.Interfaces.Core
{
    public interface IIntegrateDataService
    {
        #region Others

        Task<string> DeleteFileElementProperties(DeleteIntegrateFileElementPropertyParameter               parameter);
        Task<Area[]> ListAreas(ListIntegrateAreasParameter                                                 parameter);
        Task<ElementsWithBoundingBox[]> ListElementIds(ListIntegrateElementIdsParameter                    parameter);
        Task<ElementIdWithBoundingBox[]> ListElementsBoundingBox(ListIntegrateElementsBoundingBoxParameter parameter);
        Task<Property[]> ListElementsProperties(ListIntegrateElementsPropertiesParameter                   parameter);
        Task<MaterialInfo[]> ListFileElementMaterials(ListIntegrateFileElementMaterialsParameter           parameter);
        Task<IntegrateFileEntity[]> ListFiles(ListIntegrateFilesParameter                                  parameter);
        Task<FileViews[]> ListFileViews(ListIntegrateFileViewsParameter                                    parameter);
        Task<Floor[]> ListFloors(ListIntegrateFloorsParameter                                              parameter);
        Task<Room[]> ListRooms(ListIntegrateRoomsParameter                                                 parameter);
        Task<Area> LookupArea(LookupIntegrateAreaParameter                                                 parameter);
        Task<Tree> LookupCategoryTree(LookupIntegrateCategoryTreeParameter                                 parameter);
        Task<Property> LookupElementProperty(LookupIntegrateElementPropertyParameter                       parameter);
        Task<Property> LookupElementsCommonProperty(LookupIntegrateElementsCommonPropertiesParameter       parameter);
        Task<Property> LookupFileElementProperty(LookupIntegrateFileElementPropertyParameter               parameter);
        Task<Room> LookupRoom(LookupIntegrateRoomParameter                                                 parameter);
        Task<string> ModifyFileElementProperty(ModifyIntegrateFileElementPropertiesParameter               parameter);

        #endregion
    }
}