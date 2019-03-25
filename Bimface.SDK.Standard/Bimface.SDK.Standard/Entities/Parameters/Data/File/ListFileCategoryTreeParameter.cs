#region

using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.File
{
    public class ListFileCategoryTreeParameter : FileParameter
    {
        #region Constructors

        public ListFileCategoryTreeParameter(long fileId) : base(fileId)
        {
        }

        #endregion
    }
}