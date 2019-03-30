#region

using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.File;
using Bimface.SDK.Requests.Base;

#endregion

namespace Bimface.SDK.Requests.File
{
    internal class CreateFileOfflineDatabagRequest : BimfaceFileApiRequest
    {
        #region Constructors

        public CreateFileOfflineDatabagRequest(CreateFileOfflineDatabagParameter parameter)
            : base(parameter, HttpMethods.Put, "/offlineDatabag")
        {
            AddQuery("callback", parameter.Callback);
            AddJsonBody(parameter.Request);
        }

        #endregion
    }
}