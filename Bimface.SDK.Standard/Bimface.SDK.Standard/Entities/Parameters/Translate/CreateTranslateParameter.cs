#region

using Bimface.SDK.Entities.Core.Requests;

#endregion

namespace Bimface.SDK.Entities.Parameters.Translate
{
    public class CreateTranslateParameter
    {
        #region Constructors

        public CreateTranslateParameter(FileTranslateRequest request)
        {
            Request = request;
        }

        #endregion

        #region Properties

        public FileTranslateRequest Request { get; }

        #endregion
    }
}