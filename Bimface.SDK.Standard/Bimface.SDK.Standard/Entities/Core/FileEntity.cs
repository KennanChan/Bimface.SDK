#region

using System;

#endregion

namespace Bimface.SDK.Entities.Core
{
    public class FileEntity
    {
        #region Properties

        public DateTime CreateTime { get; set; }
        public string Etag { get; set; }
        public long? FileId { get; set; }
        public long? Length { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string Suffix { get; set; }

        #endregion
    }
}