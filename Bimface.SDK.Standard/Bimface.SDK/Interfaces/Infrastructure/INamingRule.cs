namespace Bimface.SDK.Interfaces.Infrastructure
{
    internal interface INamingRule
    {
        #region Others

        string GetName();
        string Naming(string name);

        #endregion
    }
}