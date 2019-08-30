#region

using System.Runtime.Serialization;

#endregion

namespace Bimface.SDK.Entities.Core.Responses
{
    [DataContract]
    public class Diff
    {
        #region Properties

        [DataMember(Name = "next")]
        public long? Next { get; set; }

        [DataMember(Name = "prev")]
        public long? Prev { get; set; }

        #endregion
    }
}