#region

using System.Collections.Generic;
using System.Runtime.Serialization;

#endregion

namespace Bimface.SDK.Entities.Core.Responses
{
    [DataContract]
    public class ModelVersionInfo
    {
        #region Properties

        [DataMember(Name = "config")]
        public IDictionary<string, string> Config { get; set; }

        [DataMember(Name = "databagId")]
        public string DatabagId { get; set; }

        [DataMember(Name = "isSupportComponentProperty")]
        public bool IsComponentPropertySupported { get; set; }

        [DataMember(Name = "isSupportDrawing")]
        public bool IsDrawingSupported { get; set; }

        [DataMember(Name = "isSupportFamilyTypeList")]
        public bool IsFamilyTypeListSupported { get; set; }

        #endregion
    }
}