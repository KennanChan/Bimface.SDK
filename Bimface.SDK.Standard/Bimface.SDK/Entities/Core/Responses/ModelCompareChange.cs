#region

using System.Runtime.Serialization;

#endregion

namespace Bimface.SDK.Entities.Core.Responses
{
    [DataContract]
    public class ModelCompareChange
    {
        #region Properties

        [DataMember(Name = "_A")]
        public string A { get; set; }

        [DataMember(Name = "_B")]
        public string B { get; set; }

        [DataMember(Name = "changeAttributes")]
        public Changed<Attribute>[] ChangeAttributes { get; set; }

        [DataMember(Name = "changeQuantities")]
        public Changed<Quantity>[] ChangeQuantities { get; set; }

        [DataMember(Name = "deleteAttributes")]
        public Attribute[] DeleteAttributes { get; set; }

        [DataMember(Name = "deleteQuantities")]
        public Quantity[] DeleteQuantities { get; set; }

        [DataMember(Name = "newAttributes")]
        public Attribute[] NewAttributes { get; set; }

        [DataMember(Name = "newQuantities")]
        public Quantity[] NewQuantities { get; set; }

        #endregion
    }
}