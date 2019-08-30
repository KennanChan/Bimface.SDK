#region

using System;

#endregion

namespace Bimface.SDK.Interfaces.Infrastructure
{
    public interface ILogService
    {
        #region Others

        void Debug(Type logType, object log);
        void Error(Type logType, object log);
        void Info(Type  logType, object log);

        #endregion
    }
}