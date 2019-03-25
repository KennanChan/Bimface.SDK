using Bimface.SDK.Entities.Core.Requests;
using Bimface.SDK.Entities.Parameters.Base;

namespace Bimface.SDK.Entities.Parameters.Compare
{
    public class CreateCompareParameter : IBimfaceParameter
    {
        #region Properties

        public CompareRequest Request { get; set; }

        #endregion

        #region Interface Implementations

        public string GetName()
        {
            return "create-compare";
        }

        #endregion
    }
}