#region

using System.Collections.Generic;
using System.Runtime.Serialization;

#endregion

namespace Bimface.SDK.Entities.Core
{
    [DataContract]
    public class ModelAndView
    {
        #region Properties

        [DataMember(Name = "empty")]
        public bool Empty { get; set; }

        [DataMember(Name = "model")]
        public object Model { get; set; }

        [DataMember(Name = "modelMap")]
        public IDictionary<string, object> ModelMap { get; set; }

        [DataMember(Name = "reference")]
        public bool Reference { get; set; }

        [DataMember(Name = "status")]
        public string Status { get; set; }

        [DataMember(Name = "view")]
        public View View { get; set; }

        [DataMember(Name = "viewName")]
        public string ViewName { get; set; }

        #endregion
    }
}