#region

using Bimface.SDK.Entities.Core.Requests;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.File
{
    public class LookupFileCategoryTreeParameter : FileParameter
    {
        #region Constructors

        public LookupFileCategoryTreeParameter(long fileId) : base(fileId)
        {
        }

        #endregion

        #region Properties

        public FileTreeRequest FileTreeRequest { get; set; }

        public string TreeType { get; set; }
        public string V { get; set; }

        #endregion
    }
}