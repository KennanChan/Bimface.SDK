using Bimface.SDK.Entities.Parameters.Base;

namespace Bimface.SDK.Entities.Parameters.Compare
{
    public class LookupCompareParameter : CompareParameter, IBimfaceParameter
    {
        public LookupCompareParameter(long compareId) : base(compareId)
        {
        }

        public string GetName()
        {
            return "lookup compare";
        }
    }
}