#region

using Bimface.SDK.Entities.Parameters.Data.DSL;

#endregion

namespace Bimface.SDK.Requests.Data.DSL
{
    internal class ListRoomIdsDSLRequest : BimfaceDSLRequest
    {
        #region Constructors

        public ListRoomIdsDSLRequest(ListRoomIdsDSLParameter parameter, string apiVersion = DefaultApiVersion)
            : base(parameter, "/roomIds", apiVersion)
        {
        }

        #endregion
    }
}