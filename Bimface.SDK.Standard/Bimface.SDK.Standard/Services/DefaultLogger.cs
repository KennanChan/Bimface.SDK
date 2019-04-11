#region

using System;
using System.Diagnostics;
using Bimface.SDK.Interfaces.Infrastructure;

#endregion

namespace Bimface.SDK.Services
{
    /// <summary>
    ///     The default implementation of <see cref="ILogService" /> to output to the console
    /// </summary>
    internal class DefaultLogger : ILogService
    {
        #region Interface Implementations

        public void Debug(Type logType, object log)
        {
            InternalDebug(logType, log);
        }

        public void Error(Type logType, object log)
        {
            Console.WriteLine($"[ERROR] {logType}{Environment.NewLine}{log}");
        }

        public void Info(Type logType, object log)
        {
            Console.WriteLine($"[INFO] {logType}{Environment.NewLine}{log}");
        }

        [Conditional("DEBUG")]
        private void InternalDebug(Type logType, object log)
        {
            Console.WriteLine($"[DEBUG] {logType}{Environment.NewLine}{log}");
        }

        #endregion
    }
}