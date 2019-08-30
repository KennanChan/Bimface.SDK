#region

using System.Runtime.Serialization;

#endregion

namespace Bimface.SDK.Entities.Core.Responses.Rfa
{
    [DataContract]
    public class RfaFamilyTypeProperty : RfaFamilyType
    {
        #region Properties

        [DataMember(Name = "properties")]
        public PropertyGroup[] Properties { get; set; }

        #endregion
    }
}