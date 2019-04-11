#region

using System;
using Bimface.SDK.Extensions;
using Bimface.SDK.Interfaces.Infrastructure;

#endregion

namespace Bimface.SDK.Entities.Internal
{
    internal abstract class LogObject : RuntimeObject
    {
        #region Fields

        private Type _type;

        #endregion

        #region Properties

        protected ILogService Logger => Container.GetService<ILogService>();

        private Type Type => _type ?? (_type = GetType());

        #endregion

        #region Others

        public void Debug(object log)
        {
            Logger.Debug(Type, log);
        }

        public void Error(object log)
        {
            Logger.Error(Type, log);
        }

        public void Info(object log)
        {
            Logger.Info(Type, log);
        }

        #endregion
    }
}