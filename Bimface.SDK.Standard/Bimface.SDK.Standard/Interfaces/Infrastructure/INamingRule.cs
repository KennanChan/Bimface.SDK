namespace Bimface.SDK.Interfaces.Infrastructure
{
    internal interface INamingRule
    {
        string Naming(string name);
        string GetName();
    }
}
