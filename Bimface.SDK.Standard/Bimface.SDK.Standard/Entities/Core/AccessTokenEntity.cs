#region

using System;

#endregion

namespace Bimface.SDK.Entities.Core
{
    internal class AccessTokenEntity
    {
        #region Properties

        public DateTime ExpireTime { get; set; }
        public string Token { get; set; }

        #endregion
    }
}