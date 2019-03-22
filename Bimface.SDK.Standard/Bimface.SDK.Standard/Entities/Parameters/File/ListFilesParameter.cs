#region

using System;

#endregion

namespace Bimface.SDK.Entities.Parameters.File
{
    public class ListFilesParameter
    {
        #region Properties

        public DateTime EndTime   { get; set; }
        public long?    Offset    { get; set; }
        public long?    Rows      { get; set; }
        public string   Scope     { get; set; }
        public DateTime StartTime { get; set; }
        public string   Status    { get; set; }
        public string   Suffix    { get; set; }

        #endregion
    }
}