#region

using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.File;
using Bimface.SDK.Requests.Base;

#endregion

namespace Bimface.SDK.Requests.File
{
    internal class LookupFileOfflineDatabagRequest : BimfaceFileApiRequest
    {
        #region Constructors

        public LookupFileOfflineDatabagRequest(LookupFileOfflineDatabagParameter parameter)
            : base(parameter, HttpMethods.Get, "/offlineDatabag")
        {
        }

        #endregion
    }
}