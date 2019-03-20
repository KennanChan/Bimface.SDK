namespace Bimface.SDK.Entities
{
    public class AppCredential
    {
        public AppCredential(string appKey, string appSecret)
        {
            AppKey = appKey;
            AppSecret = appSecret;
        }

        public string AppKey { get; }
        public string AppSecret { get; }
    }
}