#region

using Bimface.SDK.Entities.Core.Requests;

#endregion

namespace Bimface.SDK.Entities.Parameters.Integrate
{
    public class CreateIntegrateParameter
    {
        #region Constructors

        public CreateIntegrateParameter(FileIntegrateRequest request)
        {
            Request = request;
        }

        #endregion

        #region Properties

        public FileIntegrateRequest Request { get; }

        #endregion
    }
}