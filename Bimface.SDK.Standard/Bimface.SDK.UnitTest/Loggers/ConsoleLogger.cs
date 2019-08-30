#region

using System;
using Bimface.SDK.Interfaces.Infrastructure;

#endregion

namespace Bimface.SDK.Test.Loggers
{
    public class ConsoleLogger : ILogService
    {
        #region Interface Implementations

        public void Debug(Type logType, object log)
        {
            Console.WriteLine($@"[DEBUG] {logType.FullName}{Environment.NewLine}{log}");
        }

        public void Error(Type logType, object log)
        {
            Console.WriteLine($@"[ERROR] {logType.FullName}{Environment.NewLine}{log}");
        }

        public void Info(Type logType, object log)
        {
            Console.WriteLine($@"[INFO] {logType.FullName}{Environment.NewLine}{log}");
        }

        #endregion
    }
}