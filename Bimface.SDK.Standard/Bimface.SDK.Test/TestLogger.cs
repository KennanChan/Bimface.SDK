#region

using System;
using Bimface.SDK.Interfaces.Infrastructure;
using Xunit.Abstractions;

#endregion

namespace Bimface.SDK.Test
{
    internal class TestLogger : ILogService
    {
        #region Constructors

        public TestLogger(ITestOutputHelper output)
        {
            Output = output;
        }

        #endregion

        #region Properties

        private ITestOutputHelper Output { get; }

        #endregion

        #region Interface Implementations

        public void Debug(Type logType, object log)
        {
            Output.WriteLine($"[DEBUG] {logType.FullName}{Environment.NewLine}{log}");
        }

        public void Error(Type logType, object log)
        {
            Output.WriteLine($"[ERROR] {logType.FullName}{Environment.NewLine}{log}");
        }

        public void Info(Type logType, object log)
        {
            Output.WriteLine($"[INFO] {logType.FullName}{Environment.NewLine}{log}");
        }

        #endregion
    }
}