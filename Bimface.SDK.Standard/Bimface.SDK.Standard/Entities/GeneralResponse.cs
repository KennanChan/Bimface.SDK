using System.Runtime.Serialization;

namespace Bimface.SDK.Entities
{
    [DataContract]
    public class GeneralResponse<T> : GeneralResponse
    {
        #region Properties

        [DataMember(Name = "data")] public new T Data { get; set; }

        #endregion
    }

    [DataContract]
    public class GeneralResponse
    {
        #region Properties

        [DataMember(Name = "code")] public string Code { get; set; }
        [DataMember(Name = "data")] public object Data { get; set; }
        [DataMember(Name = "message")] public string Message { get; set; }

        #endregion
    }
}