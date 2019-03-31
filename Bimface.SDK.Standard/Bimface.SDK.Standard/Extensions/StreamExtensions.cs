#region

using System;
using System.IO;
using System.Text;

#endregion

namespace Bimface.SDK.Extensions
{
    public static class StreamExtensions
    {
        #region Others

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

        /// <summary>
        ///     Copy the binary data from one <see cref="Stream"/> to another
        /// </summary>
        /// <param name="source">The original <see cref="Stream"/></param>
        /// <param name="target">The target <see cref="Stream"/></param>
        /// <param name="bufferSize">The size of memory used to buffer the binary data</param>
        /// <param name="onBytesCopied">The handler that invoked each time some binary data copied</param>
        public static void CopyTo(this Stream source, Stream target, int bufferSize = 1024,
                                  Action<int> onBytesCopied = null)
        {
            var buffer     = new byte[bufferSize];
            var totalCount = 0;
            int count;
            while ((count = source.Read(buffer, 0, buffer.Length)) > 0)
            {
                target.Write(buffer, 0, count);
                totalCount += count;
                onBytesCopied?.Invoke(totalCount);
            }
        }

        #endregion
    }
}