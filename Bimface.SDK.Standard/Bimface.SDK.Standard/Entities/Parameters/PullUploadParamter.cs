﻿namespace Bimface.SDK.Entities.Parameters
{
    /// <summary>
    ///     Parameters used to ask bimface to download a remote file as the file to be uploaded
    ///     请求bimface从指定的远程路径下载文件，并将下载得到的文件作为上传到bimface的文件
    /// </summary>
    public class PullUploadParamter
    {
        #region Constructors

        public PullUploadParamter(string name, string url, string etag, string sourceId)
        {
            Name     = name;
            Url      = url;
            Etag     = etag;
            SourceId = sourceId;
        }

        public PullUploadParamter(string name, string url, string etag) : this(name, url, etag, null)
        {
        }

        public PullUploadParamter(string name, string url) : this(name, url, null, null)
        {
        }

        #endregion

        #region Properties

        /// <summary>
        ///     The fingerprint of the file, that usually means the hash of the file
        ///     文件Id，通常是文件的hash值
        /// </summary>
        public string Etag { get; }

        /// <summary>
        ///     The name of the file
        ///     文件名
        /// </summary>
        public string Name { get; }

        /// <summary>
        ///     The id of the file, that is usually used for establishing relationship between bimface and the invoker's business system
        ///     自定义文件Id，通常用于在bimface文件系统和调用方业务系统之间建立关系
        /// </summary>
        public string SourceId { get; }

        /// <summary>
        ///     The remote address of the file. HTTP is currently the only supporting protocol.
        ///     要上传文件的远程路径。当前只支持HTTP协议
        /// </summary>
        public string Url { get; }

        #endregion
    }
}