using Bimface.SDK.Entities.Core.Requests;
using Bimface.SDK.Entities.Parameters.Base;

namespace Bimface.SDK.Entities.Parameters.Integrate
{
    public class CreateIntegrateOfflineDatabagParameter : IntegrateParameter
    {
        #region Constructors

        public CreateIntegrateOfflineDatabagParameter(long fileId, string callback, DatabagDerivativeRequest request)
            : base(fileId)
        {
            Callback = callback;
            Request = request;
        }

        #endregion

        #region Properties

        public string Callback { get; }
        public DatabagDerivativeRequest Request { get; }

        #endregion
    }
}