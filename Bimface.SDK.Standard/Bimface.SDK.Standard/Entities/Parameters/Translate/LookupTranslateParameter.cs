#region

using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Translate
{
    [BimfaceFileHttpRequest(HttpMethods.Get, "/translate/{fileId}")]
    public class LookupTranslateParameter : FileParameter
    {
        #region Constructors

        public LookupTranslateParameter(long fileId) : base(fileId)
        {
        }

        #endregion
    }
}