﻿using System.Runtime.Serialization;

namespace Bimface.SDK.Entities.Core
{
    [DataContract]
    public class MaterialInfo
    {
        #region Properties

        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "parameters")]
        public PropertyGroup[] Parameters { get; set; }

        #endregion
    }
}