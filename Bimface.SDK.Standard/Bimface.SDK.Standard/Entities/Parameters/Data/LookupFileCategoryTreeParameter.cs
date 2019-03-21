using Bimface.SDK.Entities.Core.Requests;
using Bimface.SDK.Entities.Parameters.Base;

namespace Bimface.SDK.Entities.Parameters.Data
{
    public class LookupFileCategoryTreeParameter : FileParameter
    {
        public LookupFileCategoryTreeParameter(long fileId) : base(fileId)
        {
        }

        public string TreeType { get; set; }
        public string V { get; set; }
        public FileTreeRequest FileTreeRequest { get; set; }
    }
}
