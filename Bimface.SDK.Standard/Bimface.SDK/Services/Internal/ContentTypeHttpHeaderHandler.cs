#region

using System.Net;

#endregion

namespace Bimface.SDK.Services.Internal
{
    internal class ContentTypeHttpHeaderHandler : HttpHeaderNameHandler
    {
        #region Properties

        protected override string TargetKey { get; } = "content-type";

        #endregion

        #region Others

        public override void SetHeader(HttpWebRequest request, string key, string value)
        {
            request.ContentType = value;
        }

        #endregion
    }
}