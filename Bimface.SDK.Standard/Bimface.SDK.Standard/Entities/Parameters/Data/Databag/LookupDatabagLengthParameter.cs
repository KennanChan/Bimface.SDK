#region

using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.Databag
{
    public class LookupDatabagLengthParameter : FileParameter
    {
        #region Constructors

        public LookupDatabagLengthParameter(long fileId) : base(fileId)
        {
        }

        #endregion
    }
}