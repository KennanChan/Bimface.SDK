#region

using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.File
{
    public class ListFileDrawingSheetsParameter : FileParameter
    {
        #region Constructors

        public ListFileDrawingSheetsParameter(long fileId) : base(fileId)
        {
        }

        #endregion
    }
}