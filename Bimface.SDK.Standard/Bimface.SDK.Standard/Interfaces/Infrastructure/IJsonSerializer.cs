namespace Bimface.SDK.Interfaces.Infrastructure
{
    public interface IJsonSerializer
    {
        #region Others

        T Deserialize<T>(string json);
        string Serialize(object obj);

        #endregion
    }
}