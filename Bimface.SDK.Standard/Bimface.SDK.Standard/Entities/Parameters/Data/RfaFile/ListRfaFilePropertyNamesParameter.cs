#region

using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.RfaFile
{
    public class ListRfaFilePropertyNamesParameter : FileParameter
    {
        #region Constructors

        public ListRfaFilePropertyNamesParameter(long fileId) : base(fileId)
        {
        }

        #endregion
    }
}