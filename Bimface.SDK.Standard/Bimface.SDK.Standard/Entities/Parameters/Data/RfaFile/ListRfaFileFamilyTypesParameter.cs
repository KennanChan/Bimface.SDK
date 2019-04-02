#region

using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.RfaFile
{
    public class ListRfaFileFamilyTypesParameter : FileParameter
    {
        #region Constructors

        public ListRfaFileFamilyTypesParameter(long fileId) : base(fileId)
        {
        }

        #endregion
    }
}