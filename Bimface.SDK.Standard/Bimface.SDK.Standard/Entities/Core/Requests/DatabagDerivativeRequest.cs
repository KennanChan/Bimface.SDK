#region

using System.Collections.Generic;
using System.Runtime.Serialization;

#endregion

namespace Bimface.SDK.Entities.Core.Requests
{
    [DataContract]
    public class DatabagDerivativeRequest
    {
        #region Properties

        [DataMember(Name = "config")] public IDictionary<string, string> Config { get; set; }

        #endregion
    }
}