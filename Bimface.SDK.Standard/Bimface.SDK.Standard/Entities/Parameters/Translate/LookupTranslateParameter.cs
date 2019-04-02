#region

using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Translate
{
    [HttpRequest(HttpMethods.Get, "https://file.bimface.com", "/translate/:fileId")]
    public class LookupTranslateParameter : FileParameter
    {
        #region Constructors

        public LookupTranslateParameter(long fileId) : base(fileId)
        {
        }

        #endregion
    }
}