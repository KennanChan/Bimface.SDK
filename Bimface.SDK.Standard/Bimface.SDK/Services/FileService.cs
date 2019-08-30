#region

using System.Collections.Generic;
using System.Threading.Tasks;
using Bimface.SDK.Entities.Core.Responses;
using Bimface.SDK.Entities.Parameters.File;
using Bimface.SDK.Interfaces.Core;
using Bimface.SDK.Interfaces.Infrastructure;

#endregion

namespace Bimface.SDK.Services
{
    internal class FileService : HttpService, IFileService
    {
        #region Interface Implementations

        public Task<AppendFileEntity> CreateAppendFile(CreateAppendFileParameter parameter)
        {
            return FetchAsync<AppendFileEntity, CreateAppendFileParameter>(parameter);
        }

        public Task<UploadPolicyEntity> CreateUploadPolicy(FetchUploadPolicyParameter parameter)
        {
            return FetchAsync<UploadPolicyEntity, FetchUploadPolicyParameter>(parameter);
        }

        public Task DeleteFile(DeleteFileParameter parameter)
        {
            return SendAsync(parameter);
        }

        public Task<AppendFileEntity> FetchAppendFile(LookupAppendFileParameter parameter)
        {
            return FetchAsync<AppendFileEntity, LookupAppendFileParameter>(parameter);
        }

        public Task<string> FetchFileTemporaryDownloadUrl(FileDownloadAddressParameter parameter)
        {
            return FetchAsync<string, FileDownloadAddressParameter>(parameter);
        }

        public Task<List<FileEntity>> ListFiles(ListFilesParameter parameter)
        {
            return FetchAsync<List<FileEntity>, ListFilesParameter>(parameter);
        }

        public Task<SupportFileEntity> ListSupportFileTypes(ListSupportFileTypesParameter parameter)
        {
            return FetchAsync<SupportFileEntity, ListSupportFileTypesParameter>(parameter);
        }

        public Task<FileEntity> LookupFileMeta(LookupFileParameter parameter)
        {
            return FetchAsync<FileEntity, LookupFileParameter>(parameter);
        }

        public Task<FileUploadStatusEntity> LookupFileUploadStatus(LookupFileUploadStatusParameter parameter)
        {
            return FetchAsync<FileUploadStatusEntity, LookupFileUploadStatusParameter>(parameter);
        }

        public Task<AppendFileEntity> ResumeAppendFile(ResumeAppendFileParameter parameter)
        {
            return FetchAsync<AppendFileEntity, ResumeAppendFileParameter>(parameter);
        }

        public Task<FileEntity> Upload(PushUploadParameter parameter, IProgress<double> progressReporter = null)
        {
            return FetchAsync<FileEntity, PushUploadParameter>(parameter, progressReporter);
        }

        public Task<FileEntity> Upload(PullUploadParameter parameter)
        {
            return FetchAsync<FileEntity, PullUploadParameter>(parameter);
        }

        #endregion
    }
}