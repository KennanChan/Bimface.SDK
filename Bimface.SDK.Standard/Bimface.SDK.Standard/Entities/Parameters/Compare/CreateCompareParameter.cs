#region

using Bimface.SDK.Entities.Core.Requests;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Compare
{
    public class CreateCompareParameter : HttpParameter
    {
        #region Properties

        public CompareRequest Request { get; set; }

        #endregion
    }
}