#region

using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.File
{
    public class LookupFileMetaParameter : FileParameter
    {
        #region Constructors

        public LookupFileMetaParameter(long fileId) : base(fileId)
        {
        }

        #endregion
    }
}