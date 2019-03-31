#region

using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.File
{
    public class LookupFileParameter : FileParameter
    {
        #region Constructors

        public LookupFileParameter(long fileId) : base(fileId)
        {
        }

        #endregion
    }
}