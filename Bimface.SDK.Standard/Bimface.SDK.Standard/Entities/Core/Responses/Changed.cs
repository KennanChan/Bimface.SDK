#region

using System.Runtime.Serialization;

#endregion

namespace Bimface.SDK.Entities.Core.Responses
{
    [DataContract]
    public class Changed<T>
    {
        #region Properties

        [DataMember(Name = "_A")]
        public T A { get; set; }

        [DataMember(Name = "_B")]
        public T B { get; set; }

        #endregion
    }
}