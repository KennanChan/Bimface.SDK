#region

using System;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection;
using Bimface.SDK.Entities.Internal;
using Bimface.SDK.Interfaces.Infrastructure;

#endregion

namespace Bimface.SDK.Services
{
    /// <summary>
    ///     Initialize the service by searching all the types within the current <see cref="AppDomain"/>
    /// </summary>
    internal abstract class AppDomainServiceInitializer : LogObject, IServiceInitializer, IDisposable
    {
        public bool HasInitialized { get; protected set; }

        #region Interface Implementations

        public virtual void Dispose()
        {
            AppDomain.CurrentDomain.AssemblyLoad -= CurrentDomain_AssemblyLoad;
        }

        public void Initialize(IServiceContainer container)
        {
            if (HasInitialized) return;
            AppDomain.CurrentDomain.AssemblyLoad += CurrentDomain_AssemblyLoad;
            AppDomain.CurrentDomain.GetAssemblies().ToList().ForEach(HandleAssembly);
            Initialized();
            HasInitialized = true;
        }

        #endregion

        #region Others

        protected abstract void HandleAssembly(Assembly assembly);
        protected abstract void Initialized();

        private void CurrentDomain_AssemblyLoad(object sender, AssemblyLoadEventArgs args)
        {
            HandleAssembly(args.LoadedAssembly);
        }

        #endregion
    }
}