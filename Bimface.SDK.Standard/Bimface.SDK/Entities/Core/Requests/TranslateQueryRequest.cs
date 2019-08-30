#region

using System;
using System.Runtime.Serialization;
using Bimface.SDK.Entities.Core.Common;

#endregion

namespace Bimface.SDK.Entities.Core.Requests
{
    [DataContract]
    public class TranslateQueryRequest
    {
        #region Properties

        [DataMember(Name = "appKey")]
        public string AppKey { get; set; }

        public DateTime EndDate { get; set; } = DateTime.Now;

        [DataMember(Name = "fileId")]
        public long? FileId { get; set; }

        [DataMember(Name = "fileName")]
        public string FileName { get; set; }

        [DataMember(Name = "pageNo")]
        public int? PageNo { get; set; } = 1;

        [DataMember(Name = "pageSize")]
        public int? PageSize { get; set; } = 30;

        [DataMember(Name = "sortType")]
        public string SortType { get; set; }

        [DataMember(Name = "sourceId")]
        public string SourceId { get; set; }

        public DateTime StartDate { get; set; }

        [DataMember(Name = "startDate")]
        internal string StartDateString
        {
            get => StartDate.ToString(Constants.DateFormat);
            set => StartDate = DateTime.Parse(value);
        }

        [DataMember(Name = "status")]
        public JobStatus? Status { get; set; }

        [DataMember(Name = "suffix")]
        public string Suffix { get; set; }

        [DataMember(Name = "endDate")]
        internal string EndDateString
        {
            get => EndDate.ToString(Constants.DateFormat);
            set => EndDate = DateTime.Parse(value);
        }

        #endregion
    }
}