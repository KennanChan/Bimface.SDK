using System;

namespace Bimface.SDK.Entities.Core
{
    public class DatabagDerivativeEntity
    {
        public DateTime CreateTime     { get; set; }
        public string   DatebagVersion { get; set; }
        public long?    Length         { get; set; }
        public string   Reason         { get; set; }
        public string   Status         { get; set; }
    }
}
