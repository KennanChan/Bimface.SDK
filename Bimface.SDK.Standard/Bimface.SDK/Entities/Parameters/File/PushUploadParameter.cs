#region

using System.IO;
using Bimface.SDK.Attributes;
using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Base;
using Bimface.SDK.Extensions;

#endregion

namespace Bimface.SDK.Entities.Parameters.File
{
    /// <summary>
    ///     Parameters used to upload a file to bimface
    /// </summary>
    [BimfaceAuth]
    [BimfaceFileHttpRequest(HttpMethods.Put, "/upload")]
    public class PushUploadParameter : HttpParameter
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

        public PushUploadParameter(string name, string localFilePath, string sourceId = null) : this(name,
            new FileInfo(localFilePath), sourceId)
        {
        }

        public PushUploadParameter(string name, FileInfo localFile, string sourceId = null) : this(name,
            localFile.AsStream(),
            sourceId)
        {
        }

        public PushUploadParameter(string localFilePath, string sourceId = null) : this(Path.GetFileName(localFilePath),
            new FileInfo(localFilePath), sourceId)
        {
        }

        public PushUploadParameter(FileInfo localFile, string sourceId = null) : this(localFile.Name, localFile.AsStream(), sourceId)
        {
        }

        #endregion

        #region Properties

        [HttpQueryComponent]
        public string Name { get; }

        [HttpQueryComponent]
        public string SourceId { get; set; }

        [HttpBodyComponent(HttpContentType.Binary)]
        public Stream Stream { get; }

        #endregion
    }
}