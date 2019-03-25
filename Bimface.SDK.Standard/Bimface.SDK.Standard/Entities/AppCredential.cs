namespace Bimface.SDK.Entities
{
    public class AppCredential
    {
        #region Constructors

        public AppCredential(string appKey, string appSecret)
        {
            AppKey = appKey;
            AppSecret = appSecret;
        }

        #endregion

        #region Properties

        public string AppKey { get; }
        public string AppSecret { get; }

        #endregion
    }
}