#region

using System.Runtime.Serialization;

#endregion

namespace Bimface.SDK.Entities.Core
{
    [DataContract]
    public class View
    {
        #region Properties

        [DataMember(Name = "contentType")]
        public string ContentType { get; set; }

        #endregion
    }
}