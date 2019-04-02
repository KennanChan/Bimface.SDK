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

        #endregion

        #region Properties

        [HttpQueryComponent(Alias = "name")]
        internal string Name { get; }

        [HttpQueryComponent(Alias = "sourceId")]
        internal string SourceId { get; set; }

        [HttpBodyComponent]
        internal Stream Stream { get; }

        #endregion
    }
}