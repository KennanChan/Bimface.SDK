#region

using System.Runtime.Serialization;

#endregion

namespace Bimface.SDK.Entities.Core.Responses
{
    [DataContract]
    public class Quantity
    {
        #region Properties

        [DataMember(Name = "code")]
        public string Code { get; set; }

        [DataMember(Name = "desc")]
        public string Desc { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "qty")]
        public int? QuantityValue { get; set; }

        [DataMember(Name = "unit")]
        public string Unit { get; set; }

        #endregion
    }
}