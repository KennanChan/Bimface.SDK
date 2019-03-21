using Bimface.SDK.Entities.Core.Requests;

namespace Bimface.SDK.Entities.Parameters
{
    public class ListElementsPropertiesParameter : FileParameter
    {
        public ListElementsPropertiesParameter(long? fileId, ElementPropertyFilterRequest request) : base(fileId)
        {
            Request = request;
        }

        public ElementPropertyFilterRequest Request { get; }

        public bool? IncludeOverrides { get; set; }
    }
}