#region

using System.Runtime.Serialization;

#endregion

namespace Bimface.SDK.Entities.Core.Responses
{
    [DataContract]
    public class PagedList<T>
    {
        #region Properties

        [DataMember(Name = "list")]
        public T[] List { get; set; }

        [DataMember(Name = "page")]
        public Page Page { get; set; }

        #endregion
    }
}