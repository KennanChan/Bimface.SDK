#region

using System;

#endregion

namespace Bimface.SDK.Entities.Core
{
    public class AppendFileEntity
    {
        #region Properties

        public long?      AppendFileId { get; set; }
        public DateTime   CreateTime   { get; set; }
        public FileEntity File         { get; set; }
        public long?      Length       { get; set; }
        public string     Name         { get; set; }
        public long?      Position     { get; set; }
        public string     Status       { get; set; }

        #endregion
    }
}