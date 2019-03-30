#region

using Bimface.SDK.Entities.Core.Requests;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Compare
{
    public class CreateCompareOfflineDatabagParameter : CompareParameter
    {
        #region Constructors

        public CreateCompareOfflineDatabagParameter(long fileId, string callback, DatabagDerivativeRequest request)
            : base(fileId)
        {
            Callback = callback;
            Request  = request;
        }

        #endregion

        #region Properties

        public string                   Callback { get; }
        public DatabagDerivativeRequest Request  { get; }

        #endregion
    }
}