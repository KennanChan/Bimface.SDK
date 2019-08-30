#region

using Bimface.SDK.Extensions;
using Bimface.SDK.Interfaces.Core;
using Xunit.Abstractions;

#endregion

namespace Bimface.SDK.Test.Compare
{
    public class CompareServiceUnitTest : BimfaceUnitTest
    {
        #region Constructors

        public CompareServiceUnitTest(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
        {
            CompareService = Client.GetService<ICompareService>();
            FileService    = Client.GetService<IFileService>();
        }

        #endregion

        #region Properties

        private ICompareService CompareService { get; }
        private IFileService    FileService    { get; }

        #endregion
    }
}