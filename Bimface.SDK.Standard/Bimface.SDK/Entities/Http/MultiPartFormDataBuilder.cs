using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Bimface.SDK.Extensions;

namespace Bimface.SDK.Entities.Http
{
    /// <summary>
    ///     Provide a builder to build up an HTTP multi-part form body
    /// </summary>
    public class MultiPartFormDataBuilder : IDisposable
    {
        #region Constructors

        public MultiPartFormDataBuilder(string boundary = null)
        {
            Boundary = string.IsNullOrWhiteSpace(boundary) ? Guid.NewGuid().ToString() : boundary;
        }

        #endregion

        #region Properties

        public string Boundary { get; }
        private string BoundaryString => $"--{Boundary}";
        private string EndBoundaryString => $"--{Boundary}--";
        private List<KeyValuePair<string, Stream>> Files { get; } = new List<KeyValuePair<string, Stream>>();
        private List<KeyValuePair<string, string>> Strings { get; } = new List<KeyValuePair<string, string>>();

        #endregion

        #region Interface Implementations

        public void Dispose()
        {
            //Files.ForEach(file => file.Value.Dispose());
            Files.Clear();
            Strings.Clear();
        }

        #endregion

        #region Others

        /// <summary>
        ///     Add a file to the form data
        /// </summary>
        /// <param name="fileName">The name of the file</param>
        /// <param name="fileStream">The stream of the file content</param>
        /// <returns></returns>
        public MultiPartFormDataBuilder AddFile(string fileName, Stream fileStream)
        {
            Files.Add(new KeyValuePair<string, Stream>(fileName, fileStream));
            return this;
        }

        /// <summary>
        ///     Add a file to the form data
        /// </summary>
        /// <param name="fileName">The name of the file</param>
        /// <param name="filePath">The local path of the file</param>
        /// <returns>The current instance of <see cref="MultiPartFormDataBuilder" /></returns>
        public MultiPartFormDataBuilder AddFile(string fileName, string filePath)
        {
            return AddFile(fileName, File.OpenRead(filePath));
        }

        /// <summary>
        ///     Add a key-value pair to the form data
        /// </summary>
        /// <param name="key">The key of the data</param>
        /// <param name="value">The value of the data</param>
        /// <returns>The current instance of <see cref="MultiPartFormDataBuilder" /></returns>
        public MultiPartFormDataBuilder AddForm(string key, string value)
        {
            Strings.Add(new KeyValuePair<string, string>(key, value));
            return this;
        }

        /// <summary>
        ///     Run the form data to stream
        /// </summary>
        /// <returns></returns>
        public Stream Build()
        {
            var stream = new MemoryStream();

            Strings.ForEach(kp =>
            {
                var builder = new StringBuilder(BoundaryString).AppendLine()
                                                               .AppendLine($"Content-Disposition: form-data; name=\"{kp.Key}\"")
                                                               .AppendLine()
                                                               .AppendLine(kp.Value);
                var bytes = Encoding.UTF8.GetBytes(builder.ToString());
                stream.Write(bytes, 0, bytes.Length);
            });

            Files.ForEach(kp =>
            {
                var builder = new StringBuilder(BoundaryString).AppendLine()
                                                               .AppendLine($"Content-Disposition: form-data; name=\"file\"; filename=\"{kp.Key}\"")
                                                               .AppendLine("Content-Type: application/octet-stream")
                                                               .AppendLine();
                var bytes = Encoding.UTF8.GetBytes(builder.ToString());
                stream.Write(bytes, 0, bytes.Length);
                if (kp.Value.CanSeek)
                    kp.Value.Seek(0, SeekOrigin.Begin);
                kp.Value.CopyTo(stream);
                stream.WriteStringData("\r\n");
            });

            var end = new StringBuilder().Append(EndBoundaryString);
            var endBytes = Encoding.UTF8.GetBytes(end.ToString());
            stream.Write(endBytes, 0, endBytes.Length);
            return stream;
        }

        #endregion
    }
}
