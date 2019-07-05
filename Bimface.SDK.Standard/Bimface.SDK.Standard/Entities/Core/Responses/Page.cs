#region

using System.Runtime.Serialization;

#endregion

namespace Bimface.SDK.Entities.Core.Responses
{
    [DataContract]
    public class Page
    {
        #region Properties

        [DataMember(Name = "htmlDisplay")]
        public string HtmlDisplay { get; set; }

        [DataMember(Name = "nextPage")]
        public int? NextPage { get; set; }

        [DataMember(Name = "pageNo")]
        public int? PageNo { get; set; }

        [DataMember(Name = "pageSize")]
        public int? PageSize { get; set; }

        [DataMember(Name = "prePage")]
        public int? PrePage { get; set; }

        [DataMember(Name = "startIndex")]
        public int? StartIndex { get; set; }

        [DataMember(Name = "totalCount")]
        public int? TotalCount { get; set; }

        [DataMember(Name = "totalPages")]
        public int? TotalPages { get; set; }

        #endregion
    }
}