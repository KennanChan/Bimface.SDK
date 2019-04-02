#region

using System;
using Bimface.SDK.Attributes;
using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.File
{
    [BimfaceAuth]
    [BimfaceFileHttpRequest(HttpMethods.Get, "/files")]
    public class ListFilesParameter : HttpParameter
    {
        #region Properties

        [HttpQueryComponent(Alias = "endTime")]
        public DateTime EndTime { get; set; }

        [HttpQueryComponent(Alias = "offset")]
        public long? Offset { get; set; }

        [HttpQueryComponent(Alias = "rows")]
        public long? Rows { get; set; }

        [HttpQueryComponent(Alias = "scope")]
        public string Scope { get; set; }

        [HttpQueryComponent(Alias = "startTime")]
        public DateTime StartTime { get; set; }

        [HttpQueryComponent(Alias = "status")]
        public string Status { get; set; }

        [HttpQueryComponent(Alias = "suffix")]
        public string Suffix { get; set; }

        #endregion
    }
}