#region

using Bimface.SDK.Entities.Core.Requests;

#endregion

namespace Bimface.SDK.Entities.Parameters.Integrate
{
    public class CreateIntegrateParameter
    {
        public CreateIntegrateParameter(FileIntegrateRequest request)
        {
            Request = request;
        }

        public FileIntegrateRequest Request { get; }
    }
}