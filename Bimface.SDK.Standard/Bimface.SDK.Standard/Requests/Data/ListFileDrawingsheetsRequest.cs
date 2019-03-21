using Bimface.SDK.Entities.Parameters.Data;

namespace Bimface.SDK.Requests.Data
{
    internal class ListFileDrawingSheetsRequest : BimfaceFileDataApiRequest
    {
        public ListFileDrawingSheetsRequest(ListFileDrawingSheetsParameter parameter, string version = "v2")
            : base(parameter, "/drawingsheets", version)
        {
        }
    }
}
