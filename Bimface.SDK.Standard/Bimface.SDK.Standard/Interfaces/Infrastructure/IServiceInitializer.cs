#region

using System.ComponentModel.Design;

#endregion

namespace Bimface.SDK.Interfaces.Infrastructure
{
    internal interface IServiceInitializer
    {
        #region Others

        void Initialize(IServiceContainer container);
        bool HasInitialized { get; }

        #endregion
    }
}