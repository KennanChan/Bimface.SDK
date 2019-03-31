using Bimface.SDK.Entities.Parameters.Data.RfaFile;

namespace Bimface.SDK.Requests.Data.RfaFile
{
    internal class ListRfaFileFamilyTypesRequest : BimfaceRfaFileDataApiRequest
    {
        public ListRfaFileFamilyTypesRequest(ListRfaFileFamilyTypesParameter parameter, string apiVersion = DefaultApiVersion)
            : base(parameter, "/familyTypeMetas", apiVersion)
        {
        }
    }
}