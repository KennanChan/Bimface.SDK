﻿namespace Bimface.SDK.Entities.Parameters.File
{
    public class PolicyUploadParameter
    {
        public PolicyUploadParameter(string name, string sourceId = null)
        {
            Name     = name;
            SourceId = sourceId;
        }

        public string Name { get; }

        public string SourceId { get; set; }
    }
}