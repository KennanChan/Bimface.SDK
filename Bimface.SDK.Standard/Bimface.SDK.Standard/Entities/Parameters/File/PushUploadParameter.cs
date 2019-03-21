#region

using Bimface.SDK.Extensions;
using System.IO;

#endregion

namespace Bimface.SDK.Entities.Parameters.File
{
    /// <summary>
    ///     Parameters used to upload a file to bimface
    /// </summary>
    public class PushUploadParameter
    {
        #region Constructors

        public PushUploadParameter(string name, Stream fileStream, string sourceId)
        {
            Name = name;
            Stream = fileStream;
            SourceId = sourceId;
        }

        public PushUploadParameter(string name, Stream fileStream) : this(name, fileStream, null)
        {
        }

        public PushUploadParameter(string name, string localFilePath, string sourceId = null) : this(name,
            new FileInfo(localFilePath), sourceId)
        {
        }

        public PushUploadParameter(string name, FileInfo localFile, string sourceId = null) : this(name, localFile.AsStream(),
            sourceId)
        {
        }

        #endregion

        #region Properties

        internal string Name { get; }
        internal string SourceId { get; set; }
        internal Stream Stream { get; }

        #endregion
    }
}