#region

using System.Collections.Generic;
using System.Runtime.Serialization;
using Bimface.SDK.Entities.Core.Responses;

#endregion

namespace Bimface.SDK.Entities.Core.Requests
{
    [DataContract]
    public class FileTranslateRequest
    {
        #region Constructors

        public FileTranslateRequest(TranslateSource translateSource, int priority = 2)
        {
            Source   = translateSource;
            Priority = priority;
        }

        #endregion

        #region Properties

        [DataMember(Name = "callback")]
        public string Callback { get; set; }

        [DataMember(Name = "config")]
        public IDictionary<string, string> Config { get; set; }

        [DataMember(Name = "priority")]
        public int Priority { get; private set; }

        [DataMember(Name = "source")]
        public TranslateSource Source { get; private set; }

        #endregion
    }
}