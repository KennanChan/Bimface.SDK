#region

using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.File
{
    public class LookupFileOfflineDatabagParameter : FileParameter
    {
        #region Constructors

        public LookupFileOfflineDatabagParameter(long fileId) : base(fileId)
        {
        }

        #endregion
    }
}