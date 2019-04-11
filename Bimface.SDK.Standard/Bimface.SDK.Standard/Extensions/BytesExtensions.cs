#region

using System.IO;

#endregion

namespace Bimface.SDK.Extensions
{
    public static class BytesExtensions
    {
        #region Others

        public static Stream ToStream(this byte[] bytes)
        {
            return new MemoryStream(bytes);
        }

        #endregion
    }
}