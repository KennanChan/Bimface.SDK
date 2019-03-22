using Bimface.SDK.Entities.Parameters.Data.File;

namespace Bimface.SDK.Requests.Data.File
{
    internal class ListFileDrawingSheetsRequest : BimfaceFileDataApiRequest
    {
        public ListFileDrawingSheetsRequest(ListFileDrawingSheetsParameter parameter, string apiVersion = DefaultApiVersion)
            : base(parameter, "/drawingsheets", apiVersion)
        {
        }
    }
}
