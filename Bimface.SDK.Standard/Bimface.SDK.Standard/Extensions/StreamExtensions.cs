#region

using System.IO;
using System.Text;

#endregion

namespace Bimface.SDK.Extensions
{
    public static class StreamExtensions
    {
        public static byte[] AsBytes(this Stream stream)
        {
            var buffer = new byte[16 * 1024];
            using (var ms = new MemoryStream())
            {
                int count;
                while ((count = stream.Read(buffer, 0, buffer.Length)) > 0)
                    ms.Write(buffer, 0, count);
                return ms.ToArray();
            }
        }

        public static string AsString(this Stream stream, Encoding encoding = null)
        {
            encoding = encoding ?? Encoding.UTF8;
            if (stream.CanSeek)
                stream.Seek(0, SeekOrigin.Begin);
            return encoding.GetString(stream.AsBytes());
        }
    }
}