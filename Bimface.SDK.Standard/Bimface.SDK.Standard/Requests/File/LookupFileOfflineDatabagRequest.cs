using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.File;
using Bimface.SDK.Requests.Base;

namespace Bimface.SDK.Requests.File
{
    internal class LookupFileOfflineDatabagRequest : BimfaceFileApiRequest
    {
        public LookupFileOfflineDatabagRequest(LookupFileOfflineDatabagParameter parameter)
            : base(parameter, HttpMethods.Get, "/offlineDatabag")
        {
        }
    }
}
