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

        [HttpQueryComponent]
        public DateTime EndTime { get; set; }

        [HttpQueryComponent]
        public long? Offset { get; set; }

        [HttpQueryComponent]
        public long? Rows { get; set; }

        [HttpQueryComponent]
        public string Scope { get; set; }

        [HttpQueryComponent]
        public DateTime StartTime { get; set; }

        [HttpQueryComponent]
        public string Status { get; set; }

        [HttpQueryComponent]
        public string Suffix { get; set; }

        #endregion
    }
}