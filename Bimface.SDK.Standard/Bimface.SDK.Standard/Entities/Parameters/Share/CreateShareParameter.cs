#region

using System;
using Bimface.SDK.Attributes;
using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Share
{
    [BimfaceApiHttpRequest(HttpMethods.Post, "/share")]
    [BimfaceAuth]
    public class CreateShareParameter : HttpParameter
    {
        #region Properties

        [HttpQueryComponent(Alias = "activeHours")]
        public int? ActiveHours { get; set; }

        [HttpQueryComponent(Alias = "expireDate")]
        public DateTime ExpireDate { get; set; }

        [HttpQueryComponent(Alias = "fileId")]
        public long? FileId { get; set; }

        [HttpQueryComponent(Alias = "integrateId")]
        public long? IntegrateId { get; set; }

        [HttpQueryComponent(Alias = "needPassword")]
        public bool? NeedPassword { get; set; }

        #endregion
    }
}