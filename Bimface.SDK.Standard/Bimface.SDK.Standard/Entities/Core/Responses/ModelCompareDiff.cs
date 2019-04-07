using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Bimface.SDK.Entities.Core.Responses
{
    [DataContract]
    public class ModelCompareDiff
    {
        [DataMember(Name = "categoryId")]
        public string CategoryId { get; set; }

        [DataMember(Name = "categoryName")]
        public string CategoryName { get; set; }

        [DataMember(Name = "diffType")]
        public string DiffType { get; set; }

        [DataMember(Name = "elementId")]
        public string ElementId { get; set; }

        [DataMember(Name = "elementName")]
        public string ElementName { get; set; }

        [DataMember(Name = "family")]
        public string Family { get; set; }

        [DataMember(Name = "followingFileId")]
        public string FollowingFileId { get; set; }

        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "previousFileId")]
        public string PreviousFileId { get; set; }

        [DataMember(Name = "specialty")]
        public string Specialty { get; set; }
    }
}
