#region

using System;
using System.Runtime.Serialization;
using Bimface.SDK.Entities.Core.Common;

#endregion

namespace Bimface.SDK.Entities.Core.Requests
{
    [DataContract]
    public class IntegrateQueryRequest
    {
        #region Properties

        [DataMember(Name = "appKey")]
        public string AppKey { get; set; }

        public DateTime EndDate { private get; set; } = DateTime.Now;

        [DataMember(Name = "fileName")]
        public string FileName { get; set; }

        [DataMember(Name = "integrateId")]
        public long? IntegrateId { get; set; }

        [DataMember(Name = "integrateType")]
        public string IntegrateType { get; set; }

        [DataMember(Name = "pageNo")]
        public int? PageNo { get; set; } = 1;

        [DataMember(Name = "pageSize")]
        public int? PageSize { get; set; } = 30;

        [DataMember(Name = "sortType")]
        public string SortType { get; set; }

        [DataMember(Name = "sourceId")]
        public string SourceId { get; set; }

        public DateTime StartDate { private get; set; }

        [DataMember(Name = "startDate")]
        public string StartDateString
        {
            get => StartDate.ToString(Constants.DateFormat);
            set => StartDate = DateTime.Parse(value);
        }

        [DataMember(Name = "status")]
        public JobStatus? Status { get; set; }

        [DataMember(Name = "endDate")]
        internal string EndDateString
        {
            get => EndDate.ToString(Constants.DateFormat);
            set => EndDate = DateTime.Parse(value);
        }

        #endregion
    }
}