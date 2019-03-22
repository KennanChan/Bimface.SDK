#region

using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.File
{
    public class DeleteFileParameter : FileParameter
    {
        #region Constructors

        public DeleteFileParameter(long fileId) : base(fileId)
        {
        }

        #endregion
    }
}