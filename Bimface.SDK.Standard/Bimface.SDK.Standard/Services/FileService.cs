#region

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Bimface.SDK.Entities.Core;
using Bimface.SDK.Entities.Parameters.File;
using Bimface.SDK.Interfaces.Core;
using Bimface.SDK.Interfaces.Infrastructure.Http;
using Bimface.SDK.Requests.File;

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
            return FetchAsync<AppendFileEntity>(new CreateAppendFileRequest(parameter));
        }

        public Task<UploadPolicyEntity> CreateUploadPolicy(FetchUploadPolicyParameter parameter)
        {
            return FetchAsync<UploadPolicyEntity>(new FetchUploadPolicyRequest(parameter));
        }

        public Task DeleteFile(DeleteFileParameter parameter)
        {
            return SendAsync(new DeleteFileRequest(parameter));
        }

        public Task<AppendFileEntity> FetchAppendFile(LookupAppendFileParameter parameter)
        {
            return FetchAsync<AppendFileEntity>(new LookupAppendFileRequest(parameter));
        }

        public Task<string> FetchFileTemporaryDownloadUrl(FileDownloadAddressParameter parameter)
        {
            return FetchAsync<string>(new FileDownloadAddressRequest(parameter));
        }

        public Task<List<FileEntity>> ListFiles(ListFilesParameter parameter)
        {
            return FetchAsync<List<FileEntity>>(new ListFilesRequest(parameter));
        }

        public Task<FileEntity> LookupFileMeta(LookupFileParameter parameter)
        {
            return FetchAsync<FileEntity>(new LookupFileRequest(parameter));
        }

        public Task<AppendFileEntity> ResumeAppendFile(ResumeAppendFileParameter parameter)
        {
            return FetchAsync<AppendFileEntity>(new ResumeAppendFileRequest(parameter));
        }

        public Task<FileEntity> Upload(PushUploadParameter parameter, IProgress<double> progressReporter = null)
        {
            return FetchAsync<FileEntity>(new PushUploadRequest(parameter));
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