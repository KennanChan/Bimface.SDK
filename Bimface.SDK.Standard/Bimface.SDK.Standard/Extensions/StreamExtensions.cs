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
        ///     Copy the binary data from one <see cref="Stream" /> to another
        /// </summary>
        /// <param name="source">The original <see cref="Stream" /></param>
        /// <param name="target">The target <see cref="Stream" /></param>
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

        /// <summary>
        ///     Write the binary data of a <see cref="string" /> into the <see cref="Stream" /> using UTF-8
        /// </summary>
        /// <param name="stream">The <see cref="Stream" /> instance</param>
        /// <param name="s">The <see cref="string" /> instance</param>
        /// <returns></returns>
        public static Stream WriteStringData(this Stream stream, string s)
        {
            return stream.WriteStringData(s, Encoding.UTF8);
        }

        /// <summary>
        ///     Write the binary data of a <see cref="string" /> into the <see cref="Stream" /> using specified
        ///     <see cref="Encoding" />
        /// </summary>
        /// <param name="stream">The <see cref="Stream" /> instance</param>
        /// <param name="s">The <see cref="string" /> instance</param>
        /// <param name="encoding">The <see cref="Encoding" /> used to encode the <see cref="string" /></param>
        /// <returns>The stream it self</returns>
        public static Stream WriteStringData(this Stream stream, string s, Encoding encoding)
        {
            if (null == s || null == stream) return stream;
            var bytes = encoding.GetBytes(s);
            stream.Write(bytes, 0, bytes.Length);
            return stream;
        }

        #endregion
    }
}