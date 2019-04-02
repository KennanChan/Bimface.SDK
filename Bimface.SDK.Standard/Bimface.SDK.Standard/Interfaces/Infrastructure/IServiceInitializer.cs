using System.ComponentModel.Design;

namespace Bimface.SDK.Interfaces.Infrastructure
{
    internal interface IServiceInitializer
    {
        void Initialize(IServiceContainer container);
    }
}
