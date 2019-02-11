using System.IO;
using System.Text;

namespace Bimface.SDK.Extensions
{
    public static class StreamExtension
    {
        public static string AsString(this Stream stream, Encoding encoding)
        {
            if (null == encoding)
                encoding = Encoding.UTF8;
            if (stream.CanSeek)
                stream.Seek(0, SeekOrigin.Begin);
            return encoding.GetString(stream.AsBytes());
        }

        public static string AsString(this Stream stream)
        {
            return stream.AsString(null);
        }

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
    }
}