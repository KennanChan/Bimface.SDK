#region

using System.Runtime.Serialization;

#endregion

namespace Bimface.SDK.Entities.Core.Responses
{
    [DataContract]
    public class Pagination<T>
    {
        #region Properties

        [DataMember(Name = "data")]
        public T[] Data { get; set; }

        [DataMember(Name = "page")]
        public int? Page { get; set; }

        [DataMember(Name = "total")]
        public int? Total { get; set; }

        #endregion
    }
}