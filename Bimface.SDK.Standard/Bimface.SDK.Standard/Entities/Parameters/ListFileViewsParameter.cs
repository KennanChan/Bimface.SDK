#region

using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters
{
    public class ListFileViewsParameter : FileParameter
    {
        #region Constructors

        public ListFileViewsParameter(long fileId) : base(fileId)
        {
        }

        #endregion
    }
}