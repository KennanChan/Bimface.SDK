﻿#region

using System.Runtime.Serialization;

#endregion

namespace Bimface.SDK.Entities.Core.Responses
{
    [DataContract]
    public class FloorMappingItem
    {
        #region Properties

        [DataMember(Name = "fileFloorId")]
        public string FileFloorId { get; set; }

        [DataMember(Name = "projectFloorId")]
        public string ProjectFloorId { get; set; }

        [DataMember(Name = "projectFloorName")]
        public string ProjectFloorName { get; set; }

        #endregion
    }
}