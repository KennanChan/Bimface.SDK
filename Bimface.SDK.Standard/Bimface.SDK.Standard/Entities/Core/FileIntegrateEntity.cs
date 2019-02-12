#region

using System;

#endregion

namespace Bimface.SDK.Entities.Core
{
    public class FileIntegrateEntity
    {
        #region Properties

        public DateTime CreateTime  { get; set; }
        public long?    IntegrateId { get; set; }
        public string   Name        { get; set; }
        public string   Priority    { get; set; }
        public string   Reason      { get; set; }
        public string   SourceId    { get; set; }
        public string   Status      { get; set; }
        public object[] Thumbnails  { get; set; }

        #endregion
    }
}