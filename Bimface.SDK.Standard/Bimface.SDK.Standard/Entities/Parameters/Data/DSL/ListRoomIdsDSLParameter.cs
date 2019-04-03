#region

using Bimface.SDK.Attributes.Http;
using Bimface.SDK.DSL;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.DSL
{
    [BimfaceDataApiHttpRequest("/query/roomIds")]
    public class ListRoomIdsDSLParameter : DSLParameter
    {
        #region Constructors

        public ListRoomIdsDSLParameter(DSLQuery query) : base(query)
        {
        }

        #endregion
    }
}