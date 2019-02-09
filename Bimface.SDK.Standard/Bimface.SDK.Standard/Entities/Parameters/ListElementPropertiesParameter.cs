using System;
using Bimface.SDK.Entities.Core;

namespace Bimface.SDK.Entities.Parameters
{
    public class ListElementPropertiesParameter
    {
        public ListElementPropertiesParameter(long? fileId, ElementPropertyFilterRequest filter)
        {
            FileId = fileId;
            FilterRequest = filter;
        }

        public long? FileId { get; }
        public ElementPropertyFilterRequest FilterRequest { get; }
    }
}