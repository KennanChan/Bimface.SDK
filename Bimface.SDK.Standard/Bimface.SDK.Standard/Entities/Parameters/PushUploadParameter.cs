#region

using System.IO;
using Bimface.SDK.Extensions;

#endregion

namespace Bimface.SDK.Entities.Parameters
{
    /// <summary>
    ///     Parameters used to upload a file to bimface
    /// </summary>
    public class PushUploadParameter
    {
        #region Constructors

        public PushUploadParameter(string name, Stream fileStream, string sourceId)
        {
            Name     = name;
            Stream   = fileStream;
            SourceId = sourceId;
        }

        public PushUploadParameter(string name, Stream fileStream) : this(name, fileStream, null)
        {
        }

        public PushUploadParameter(string name, string localFilePath, string sourceId) : this(name, new FileInfo(localFilePath), sourceId)
        {
        }

        public PushUploadParameter(string name, string localFilePath) : this(name, new FileInfo(localFilePath), null)
        {
        }

        public PushUploadParameter(string name, FileInfo localFile, string sourceId) : this(name, localFile.AsStream(), sourceId)
        {
        }

        public PushUploadParameter(string name, FileInfo localFile) : this(name, localFile.AsStream(), null)
        {
        }

        #endregion

        #region Properties

        internal string Name     { get; }
        internal string SourceId { get; }
        internal Stream Stream   { get; }

        #endregion
    }
}