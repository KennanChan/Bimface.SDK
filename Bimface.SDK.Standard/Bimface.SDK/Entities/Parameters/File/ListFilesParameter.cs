#region

using System;
using Bimface.SDK.Attributes;
using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Core.Common;
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

        public DateTime EndTime
        {
            get => DateTime.Parse(EndTimeString);
            set => EndTimeString = value.ToString(Constants.DateFormat);
        }

        [HttpQueryComponent]
        public long? Offset { get; set; }

        [HttpQueryComponent]
        public long? Rows { get; set; }

        [HttpQueryComponent]
        public string Scope { get; set; }

        public DateTime StartTime
        {
            get => DateTime.Parse(StartTimeString);
            set => StartTimeString = value.ToString(Constants.DateFormat);
        }

        [HttpQueryComponent]
        public string Status { get; set; }

        [HttpQueryComponent]
        public string Suffix { get; set; }

        [HttpQueryComponent(Alias = nameof(EndTime))]
        private string EndTimeString { get; set; }

        [HttpQueryComponent(Alias = nameof(StartTime))]
        private string StartTimeString { get; set; }

        #endregion
    }
}