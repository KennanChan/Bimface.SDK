#region

using System;
using System.Runtime.Serialization;

#endregion

namespace Bimface.SDK.Entities.Core.Responses
{
    [DataContract]
    public class AccessTokenEntity
    {
        #region Fields

        private DateTime? _expireTime;

        #endregion

        #region Properties

        public DateTime? ExpireTime => _expireTime ?? (_expireTime = DateTime.Parse(ExpireTimeString));

        [DataMember(Name = "expireTime")]
        public string ExpireTimeString { get; set; }

        [DataMember(Name = "token")]
        public string Token { get; set; }

        #endregion
    }
}