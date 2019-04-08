#region

using System.Threading.Tasks;
using Bimface.SDK.Entities.Core.DSL;
using Bimface.SDK.Entities.Parameters.Data.DSL;
using Bimface.SDK.Interfaces.Core;

#endregion

namespace Bimface.SDK.Services
{
    internal class DSLDataService : HttpService, IDSLDataService
    {
        #region Interface Implementations

        public Task<AreaIdsResponse[]> ListAreaIds(ListAreaIdsDSLParameter parameter)
        {
            return FetchAsync<AreaIdsResponse[], ListAreaIdsDSLParameter>(parameter);
        }

        public Task<ElementIdsResponse[]> ListElementIds(ListElementIdsDSLParameter parameter)
        {
            return FetchAsync<ElementIdsResponse[], ListElementIdsDSLParameter>(parameter);
        }

        public Task<PropertyValuesResponse[]> ListPropertyValues(ListPropertiesDSLParameter parameter)
        {
            return FetchAsync<PropertyValuesResponse[], ListPropertiesDSLParameter>(parameter);
        }

        public Task<RoomIdsResponse[]> ListRoomIds(ListRoomIdsDSLParameter parameter)
        {
            return FetchAsync<RoomIdsResponse[], ListRoomIdsDSLParameter>(parameter);
        }

        #endregion
    }
}