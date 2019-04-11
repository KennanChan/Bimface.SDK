#region

using System.Runtime.Serialization;

#endregion

namespace Bimface.SDK.Entities
{
    [DataContract]
    public class GeneralResponse<T>
    {
        #region Properties

        [DataMember(Name = "code")]
        public string Code { get; set; }

        [DataMember(Name = "data")]
        public T Data { get; set; }

        [DataMember(Name = "message")]
        public string Message { get; set; }

        #endregion
    }
}