#region

using System;
using System.Runtime.Serialization;

#endregion

namespace Bimface.SDK.Entities.Core
{
    [DataContract]
    internal class AccessTokenEntity
    {
        #region Properties

        [DataMember(Name = "expireTime")]
        public DateTime ExpireTime { get; set; }

        [DataMember(Name = "token")]
        public string Token { get; set; }

        #endregion
    }
}