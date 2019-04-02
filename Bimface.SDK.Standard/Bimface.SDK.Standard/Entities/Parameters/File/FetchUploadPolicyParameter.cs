using Bimface.SDK.Attributes;
using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Base;

namespace Bimface.SDK.Entities.Parameters.File
{
    [BimfaceFileHttpRequest(HttpMethods.Get, "/upload/policy")]
    [BimfaceAuth]
    public class FetchUploadPolicyParameter : HttpParameter
    {
        #region Constructors

        public FetchUploadPolicyParameter(string name)
        {
            Name = name;
        }

        #endregion

        #region Properties

        [HttpQueryComponent(Alias = "name")]
        public string Name { get; }

        [HttpQueryComponent(Alias = "sourceId")]
        public string SourceId { get; set; }

        #endregion
    }
}