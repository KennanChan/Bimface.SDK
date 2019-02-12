#region

using System;

#endregion

namespace Bimface.SDK.Entities.Core
{
    public class ModelCompareEntity
    {
        #region Properties

        public long?    CompareId  { get; set; }
        public DateTime CreateTime { get; set; }
        public string   Name       { get; set; }
        public int?     Priority   { get; set; }
        public string   Reason     { get; set; }
        public string   SourceId   { get; set; }
        public string   Status     { get; set; }
        public object[] Thumbnails { get; set; }

        #endregion
    }
}