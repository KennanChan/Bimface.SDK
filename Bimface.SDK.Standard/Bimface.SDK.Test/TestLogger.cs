#region

using System;
using System.IO;
using System.Text;
using Bimface.SDK.Interfaces.Infrastructure;
using Xunit.Abstractions;

#endregion

namespace Bimface.SDK.Test
{
    internal class TestLogger : TextWriter, ILogService
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

        public override Encoding Encoding { get; } = Encoding.UTF8;

        public override void Write(object value)
        {
            WriteLine(value);
        }

        public override void Write(string value)
        {
            WriteLine(value);
        }

        public override void WriteLine(object value)
        {
            WriteLine(value.ToString());
        }

        public override void WriteLine(string value)
        {
            Output.WriteLine(value);
        }
    }
}