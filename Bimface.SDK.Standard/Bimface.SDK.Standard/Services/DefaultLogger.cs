using System;
using Bimface.SDK.Interfaces.Infrastructure;

namespace Bimface.SDK.Services
{
    internal class DefaultLogger : ILog
    {
        #region Interface Implementations

        public void Debug(Type logType, object log)
        {
            Console.WriteLine($"[DEBUG] {logType}{Environment.NewLine}{log}");
        }

        public void Error(Type logType, object log)
        {
            Console.WriteLine($"[ERROR] {logType}{Environment.NewLine}{log}");
        }

        public void Info(Type logType, object log)
        {
            Console.WriteLine($"[INFO] {logType}{Environment.NewLine}{log}");
        }

        #endregion
    }
}