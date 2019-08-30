#region

using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using Bimface.SDK.Entities.Core.Responses;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Internal;
using Bimface.SDK.Entities.Parameters.File;
using Bimface.SDK.Interfaces.Core;
using Bimface.SDK.Interfaces.Infrastructure;

#endregion

namespace Bimface.SDK.Extensions
{
    public static class FileServiceExtensions
    {
        #region Others

        public static async Task<FileEntity> OssUpload(this IFileService fileService,
                                                       string            filePath,
                                                       string            name    = null,
                                                       OssUploadOptions  options = null)
        {
            name    = string.IsNullOrWhiteSpace(name) ? Path.GetFileName(filePath) : name;
            options = options ?? new OssUploadOptions(((RuntimeObject) fileService).Container.GetService<IResponseResolver>());
            var policy      = await fileService.CreateUploadPolicy(new FetchUploadPolicyParameter(name));
            var httpRequest = WebRequest.Create(new Uri(policy.Host));
            httpRequest.Method = WebRequestMethods.Http.Post;

            var formBuilder = new MultiPartFormDataBuilder()
                             .AddForm("name", name)
                             .AddForm("key", policy.ObjectKey)
                             .AddForm("policy", policy.Policy)
                             .AddForm("OSSAccessKeyId", policy.AccessId)
                             .AddForm("success_action_status", "200")
                             .AddForm("callback", policy.CallbackBody)
                             .AddForm("Expires", policy.Expire.ToString())
                             .AddForm("Signature", policy.Signature)
                             .AddFile(name, File.OpenRead(filePath));
            httpRequest.ContentType = $"multipart/form-data; boundary={formBuilder.Boundary}";

            using (var form = formBuilder.Build())
            {
                //Notify the socket about the length of the body in order to produce progress
                httpRequest.ContentLength = form.Length;
                var body = httpRequest.GetRequestStream();
                form.Seek(0, SeekOrigin.Begin);
                form.CopyTo(body, options.BufferSize);
                body.Close();
                form.Close();
                formBuilder.Dispose();
            }

            var response = (HttpWebResponse) httpRequest.GetResponse();
            var file     = options.ResponseResolver.Resolve<FileEntity>(response.GetResponseStream());
            return file;
        }

        #endregion
    }

    public class OssUploadOptions
    {
        public OssUploadOptions(IResponseResolver responseResolver)
        {
            ResponseResolver = responseResolver;
        }

        #region Properties

        public int               BufferSize       { get; set; } = 4096;
        public IResponseResolver ResponseResolver { get; set; }

        #endregion
    }
}