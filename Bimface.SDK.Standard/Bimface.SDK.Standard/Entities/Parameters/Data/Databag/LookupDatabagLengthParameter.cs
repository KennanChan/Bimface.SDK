#region

using Bimface.SDK.Attributes;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.Databag
{
    [BimfaceAuth]
    public class LookupDatabagLengthParameter : FileParameter
    {
        #region Constructors

        public LookupDatabagLengthParameter(long fileId) : base(fileId)
        {
        }

        #endregion
    }
}