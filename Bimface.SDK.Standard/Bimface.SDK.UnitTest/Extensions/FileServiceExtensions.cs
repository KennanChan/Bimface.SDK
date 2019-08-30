#region

using System;
using System.Linq;
using System.Threading.Tasks;
using Bimface.SDK.Entities.Core.Responses;
using Bimface.SDK.Entities.Parameters.File;
using Bimface.SDK.Interfaces.Core;
using Xunit;

#endregion

namespace Bimface.SDK.Test.Extensions
{
    public static class FileServiceExtensions
    {
        #region Others

        public static async Task TemporarilyUpload(this IFileService fileService, string url, string name, Func<FileEntity, Task> handler)
        {
            var file = await fileService.Upload(new PullUploadParameter(name, url));
            Assert.NotNull(file);
            Assert.True(file.FileId.HasValue);
            if (null != handler)
                await handler.Invoke(file);
            await fileService.DeleteFile(new DeleteFileParameter(file.FileId.Value));
        }

        public static async Task TemporarilyUpload(this IFileService fileService, string[] paths, Func<FileEntity[], Task> handler)
        {
            Assert.NotNull(paths);
            Assert.NotEmpty(paths);
            Assert.DoesNotContain(paths, string.IsNullOrWhiteSpace);
            var files = await Task.WhenAll(paths.Select(path => fileService.Upload(new PushUploadParameter(path))));

            Assert.NotNull(files);
            Assert.NotEmpty(files);
            Assert.DoesNotContain(files, x => x == null);
            Assert.DoesNotContain(files.Select(f => f.FileId), x => !x.HasValue);

            if (null != handler)
                await handler.Invoke(files);

            await Task.WhenAll(files.Select(file => fileService.DeleteFile(new DeleteFileParameter(file.FileId.Value))));
        }

        #endregion
    }
}