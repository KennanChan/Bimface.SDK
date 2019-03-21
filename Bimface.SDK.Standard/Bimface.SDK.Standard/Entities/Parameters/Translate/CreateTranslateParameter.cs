#region

using Bimface.SDK.Entities.Core.Requests;

#endregion

namespace Bimface.SDK.Entities.Parameters.Translate
{
    public class CreateTranslateParameter
    {
        public CreateTranslateParameter(FileTranslateRequest request)
        {
            Request = request;
        }

        #region Properties

        public FileTranslateRequest Request { get; }

        #endregion
    }
}