#region

using System.Collections.Generic;
using System.Threading.Tasks;
using Bimface.SDK.Entities.Core.Responses;
using Bimface.SDK.Entities.Parameters.File;
using Bimface.SDK.Interfaces.Infrastructure;

#endregion

namespace Bimface.SDK.Interfaces.Core
{
    public interface IFileService
    {
        #region Others

        Task<AppendFileEntity> CreateAppendFile(CreateAppendFileParameter                   parameter);
        Task<UploadPolicyEntity> CreateUploadPolicy(FetchUploadPolicyParameter              parameter);
        Task DeleteFile(DeleteFileParameter                                                 parameter);
        Task<AppendFileEntity> FetchAppendFile(LookupAppendFileParameter                    parameter);
        Task<string> FetchFileTemporaryDownloadUrl(FileDownloadAddressParameter             parameter);
        Task<List<FileEntity>> ListFiles(ListFilesParameter                                 parameter);
        Task<SupportFileEntity> ListSupportFileTypes(ListSupportFileTypesParameter          parameter);
        Task<FileEntity> LookupFileMeta(LookupFileParameter                                 parameter);
        Task<FileUploadStatusEntity> LookupFileUploadStatus(LookupFileUploadStatusParameter parameter);
        Task<AppendFileEntity> ResumeAppendFile(ResumeAppendFileParameter                   parameter);
        Task<FileEntity> Upload(PushUploadParameter                                         parameter, IProgress<double> progressReporter = null);
        Task<FileEntity> Upload(PullUploadParameter                                         parameter);

        #endregion
    }
}