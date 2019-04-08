#region

using System.Threading.Tasks;
using Bimface.SDK.Entities.Core.DSL;
using Bimface.SDK.Entities.Parameters.Data.DSL;

#endregion

namespace Bimface.SDK.Interfaces.Core
{
    public interface IDSLDataService
    {
        #region Others

        Task<AreaIdsResponse[]> ListAreaIds(ListAreaIdsDSLParameter                  parameter);
        Task<ElementIdsResponse[]> ListElementIds(ListElementIdsDSLParameter         parameter);
        Task<PropertyValuesResponse[]> ListPropertyValues(ListPropertiesDSLParameter parameter);
        Task<RoomIdsResponse[]> ListRoomIds(ListRoomIdsDSLParameter                  parameter);

        #endregion
    }
}