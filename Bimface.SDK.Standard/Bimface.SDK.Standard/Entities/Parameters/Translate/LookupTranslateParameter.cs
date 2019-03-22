#region

using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Translate
{
    public class LookupTranslateParameter : FileParameter
    {
        #region Constructors

        public LookupTranslateParameter(long fileId) : base(fileId)
        {
        }

        #endregion
    }
}