using Bimface.SDK.Attributes;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Data.Databag;
using Bimface.SDK.Requests.Base;

namespace Bimface.SDK.Requests.Data.Databag
{
    [BimfaceAuth]
    internal class LookupDatabagLengthRequest : BimfaceDatabagDataApiRequest
    {
        #region Constructors

        public LookupDatabagLengthRequest(LookupDatabagLengthParameter parameter, string apiVersion)
            : base(HttpMethods.Get, "/length", apiVersion)
        {
            AddQuery("fileId", parameter.FileId);
        }

        #endregion
    }
}