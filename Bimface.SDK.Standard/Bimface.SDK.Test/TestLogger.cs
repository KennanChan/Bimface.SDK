#region

using System.IO;
using System.Text;
using Xunit.Abstractions;

#endregion

namespace Bimface.SDK.Test
{
    internal class TestLogger : TextWriter
    {
        #region Constructors

        public TestLogger(ITestOutputHelper output)
        {
            Output = output;
        }

        #endregion

        #region Properties

        public override Encoding          Encoding { get; } = Encoding.UTF8;
        private         ITestOutputHelper Output   { get; }

        #endregion

        #region Others

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

        #endregion
    }
}