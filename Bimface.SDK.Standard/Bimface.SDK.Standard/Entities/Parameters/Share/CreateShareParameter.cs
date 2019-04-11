#region

using System;
using Bimface.SDK.Attributes;
using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Share
{
    [BimfaceAuth]
    [BimfaceApiHttpRequest(HttpMethods.Post, "/share")]
    public abstract class CreateShareParameter : HttpParameter
    {
        #region Properties

        [HttpQueryComponent]
        public int? ActiveHours { get; set; }

        [HttpQueryComponent]
        public DateTime ExpireDate { get; set; }

        [HttpQueryComponent]
        public bool? NeedPassword { get; set; }

        #endregion
    }
}