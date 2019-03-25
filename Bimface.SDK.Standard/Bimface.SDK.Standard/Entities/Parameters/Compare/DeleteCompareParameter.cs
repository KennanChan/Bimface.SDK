using Bimface.SDK.Entities.Parameters.Base;

namespace Bimface.SDK.Entities.Parameters.Compare
{
    public class DeleteCompareParameter : CompareParameter, IBimfaceParameter
    {
        public DeleteCompareParameter(long compareId) : base(compareId)
        {
        }

        public string GetName()
        {
            return "delete-compare";
        }
    }
}
