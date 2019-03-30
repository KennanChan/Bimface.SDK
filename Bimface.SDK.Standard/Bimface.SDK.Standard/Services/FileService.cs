﻿#region

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Bimface.SDK.Entities.Core;
using Bimface.SDK.Entities.Parameters.File;
using Bimface.SDK.Interfaces.Core;
using Bimface.SDK.Interfaces.Infrastructure.Http;

#endregion

namespace Bimface.SDK.Services
{
    internal class FileService : HttpService, IFileService
    {
        #region Constructors

        public FileService(IHttpClient client, IResponseResolver responseResolver) : base(client,
            responseResolver)
        {
        }

        #endregion

        #region Interface Implementations

        public Task<AppendFileEntity> CreateAppendFile(CreateAppendFileParameter parameter)
        {
            throw new NotImplementedException();
        }

        public Task<UploadPolicyEntity> CreateUploadPolicy(FetchUploadPolicyParameter parameter)
        {
            throw new NotImplementedException();
        }

        public Task DeleteFile(DeleteFileParameter parameter)
        {
            throw new NotImplementedException();
        }

        public Task<AppendFileEntity> FetchAppendFile(LookupAppendFileParameter parameter)
        {
            throw new NotImplementedException();
        }

        public Task<string> FetchFileTemporaryDownloadUrl(FileDownloadAddressParameter parameter)
        {
            throw new NotImplementedException();
        }

        public Task<List<FileEntity>> ListFiles(ListFilesParameter parameter)
        {
            throw new NotImplementedException();
        }

        public Task<FileEntity> LookupFileMeta(LookupFileMetaParameter parameter)
        {
            throw new NotImplementedException();
        }

        public Task<AppendFileEntity> ResumeAppendFile(ResumeAppendFileParameter parameter)
        {
            throw new NotImplementedException();
        }

        public Task<FileEntity> Upload(PushUploadParameter parameter, IProgress<long> progressReporter = null)
        {
            throw new NotImplementedException();
        }

        public Task<FileEntity> Upload(PullUploadParameter parameter)
        {
            throw new NotImplementedException();
        }

        public Task<SupportFileEntity> ViewSupportFileTypes()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}