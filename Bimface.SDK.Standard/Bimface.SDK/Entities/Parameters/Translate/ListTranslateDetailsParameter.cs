#region

using System.Net;
using Bimface.SDK.Attributes;
using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Core.Requests;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Translate
{
    [BimfaceAuth]
    [BimfaceApiHttpRequest(HttpMethods.Post, "/translateDetails")]
    public class ListTranslateDetailsParameter : HttpParameter
    {
        #region Constructors

        public ListTranslateDetailsParameter(TranslateQueryRequest request)
        {
            Request = request;
        }

        #endregion

        #region Properties

        [HttpBodyComponent]
        public TranslateQueryRequest Request { get; }

        #endregion
    }
}