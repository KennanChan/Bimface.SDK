using System.IO;

namespace Bimface.SDK.Extensions
{
    public static class BytesExtensions
    {
        public static Stream ToStream(this byte[] bytes)
        {
            return new MemoryStream(bytes);
        }
    }
}
