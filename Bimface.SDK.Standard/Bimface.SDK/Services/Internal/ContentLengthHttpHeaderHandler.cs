#region

using System.Net;

#endregion

namespace Bimface.SDK.Services.Internal
{
    internal class ContentLengthHttpHeaderHandler : HttpHeaderNameHandler
    {
        #region Properties

        protected override string TargetKey { get; } = "content-length";

        #endregion

        #region Others

        public override void SetHeader(HttpWebRequest request, string key, string value)
        {
            request.ContentLength = long.Parse(value);
        }

        #endregion
    }
}