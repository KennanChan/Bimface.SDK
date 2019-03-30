#region

using Bimface.SDK.Entities.Core.Requests;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.File
{
    public class CreateFileOfflineDatabagParameter : FileParameter
    {
        #region Constructors

        public CreateFileOfflineDatabagParameter(long fileId, string callback, DatabagDerivativeRequest request) :
            base(fileId)
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