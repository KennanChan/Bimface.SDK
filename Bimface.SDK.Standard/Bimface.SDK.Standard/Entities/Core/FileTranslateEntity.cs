#region

using System;

#endregion

namespace Bimface.SDK.Entities.Core
{
    public class FileTranslateEntity
    {
        #region Properties

        public DateTime CreateTime { get; set; }
        public string   DatabagId  { get; set; }
        public long?    FileId     { get; set; }
        public string   Name       { get; set; }
        public int?     Priority   { get; set; }
        public string   Reason     { get; set; }
        public string   Status     { get; set; }
        public object[] Thumbnails { get; set; }

        #endregion
    }
}