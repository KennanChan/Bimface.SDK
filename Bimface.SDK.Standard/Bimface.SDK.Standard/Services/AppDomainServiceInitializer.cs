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
    internal abstract class AppDomainServiceInitializer : LogObject, IServiceInitializer, IDisposable
    {
        #region Interface Implementations

        public virtual void Dispose()
        {
            AppDomain.CurrentDomain.AssemblyLoad -= CurrentDomain_AssemblyLoad;
        }

        public void Initialize(IServiceContainer container)
        {
            AppDomain.CurrentDomain.AssemblyLoad += CurrentDomain_AssemblyLoad;
            AppDomain.CurrentDomain.GetAssemblies().ToList().ForEach(Handle);
        }

        #endregion

        #region Others

        protected abstract void Handle(Assembly assembly);

        private void CurrentDomain_AssemblyLoad(object sender, AssemblyLoadEventArgs args)
        {
            Handle(args.LoadedAssembly);
        }

        #endregion
    }
}