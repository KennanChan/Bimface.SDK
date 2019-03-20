#region

using System.Collections.Generic;
using System.Runtime.Serialization;

#endregion

namespace Bimface.SDK.Entities.Core.Requests
{
    [DataContract]
    public class FileTranslateRequest
    {
        #region Properties

        [DataMember(Name = "callback")] public string Callback { get; set; }
        [DataMember(Name = "config")] public IDictionary<string, string> Config { get; set; }
        [DataMember(Name = "priority")] public int? Priority { get; set; }
        [DataMember(Name = "source")] public TranslateSource Source { get; set; }

        #endregion
    }
}