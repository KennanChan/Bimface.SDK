#region

using System;
using System.ComponentModel.Design;

#endregion

namespace Bimface.SDK
{
    public class BimfaceClient : IServiceContainer
    {
        #region Interface Implementations

        public void AddService(Type serviceType, ServiceCreatorCallback callback)
        {
            throw new NotImplementedException();
        }

        public void AddService(Type serviceType, ServiceCreatorCallback callback, bool promote)
        {
            throw new NotImplementedException();
        }

        public void AddService(Type serviceType, object serviceInstance)
        {
            throw new NotImplementedException();
        }

        public void AddService(Type serviceType, object serviceInstance, bool promote)
        {
            throw new NotImplementedException();
        }

        public void RemoveService(Type serviceType)
        {
            throw new NotImplementedException();
        }

        public void RemoveService(Type serviceType, bool promote)
        {
            throw new NotImplementedException();
        }

        public object GetService(Type serviceType)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}