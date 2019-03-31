#region

using Bimface.SDK.Entities.Parameters.Data.RfaFile;

#endregion

namespace Bimface.SDK.Requests.Data.RfaFile
{
    internal class ListRfaFilePropertyNamesRequest : BimfaceRfaFileDataApiRequest
    {
        #region Constructors

        public ListRfaFilePropertyNamesRequest(ListRfaFilePropertyNamesParameter parameter, string apiVersion = DefaultApiVersion)
            : base(parameter, "/propertyNames", apiVersion)
        {
        }

        #endregion
    }
}