using System.Threading.Tasks;
using Bimface.SDK.Entities.Core.DSL;
using Bimface.SDK.Entities.Parameters.Data.DSL;

namespace Bimface.SDK.Interfaces.Core
{
    public interface IDSLDataService
    {
        Task<ElementIdsResponse[]> ListElementIds(ListElementIdsDSLParameter         parameter);
        Task<PropertyValuesResponse[]> ListPropertyValues(ListPropertiesDSLParameter parameter);
        Task<AreaIdsResponse[]> ListAreaIds(ListAreaIdsDSLParameter                  parameter);
        Task<RoomIdsResponse[]> ListRoomIds(ListRoomIdsDSLParameter                  parameter);
    }
}