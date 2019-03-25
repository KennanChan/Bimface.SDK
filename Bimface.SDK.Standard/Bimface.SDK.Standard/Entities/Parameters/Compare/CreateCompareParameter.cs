using Bimface.SDK.Entities.Core.Requests;
using Bimface.SDK.Entities.Parameters.Base;

namespace Bimface.SDK.Entities.Parameters.Compare
{
    public class CreateCompareParameter : IBimfaceParameter
    {
        public CompareRequest Request { get; set; }

        public string GetName()
        {
            return "create-compare";
        }
    }
}