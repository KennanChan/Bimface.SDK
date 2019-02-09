using System;
namespace Bimface.SDK.Entities.Parameters
{
    public class FileDownloadAddressParameter : FileParameter
    {
        public FileDownloadAddressParameter(long? fileId) : base(fileId)
        {
        }

        public string Name { get; set; }
    }
}
