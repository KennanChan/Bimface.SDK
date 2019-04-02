#region

using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Core.Requests;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Translate
{
    [HttpRequest(HttpMethods.Put, "http://file.bimface.com", "/translate")]
    public class CreateTranslateParameter : HttpParameter
    {
        #region Constructors

        public CreateTranslateParameter(FileTranslateRequest request)
        {
            Request = request;
        }

        #endregion

        #region Properties

        [HttpBodyComponent]
        public FileTranslateRequest Request { get; }

        #endregion
    }
}