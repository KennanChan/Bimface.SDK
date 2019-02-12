#region

using System;

#endregion

namespace Bimface.SDK.Entities.Core
{
    public class DatabagDerivativeEntity
    {
        #region Properties

        public DateTime CreateTime     { get; set; }
        public string   DatebagVersion { get; set; }
        public long?    Length         { get; set; }
        public string   Reason         { get; set; }
        public string   Status         { get; set; }

        #endregion
    }
}