namespace Bimface.SDK.Entities.Parameters
{
    public class LookupElementPropertyParameter : FileParameter
    {
        #region Constructors

        public LookupElementPropertyParameter(long? fileId, string elementId) : base(fileId)
        {
            ElementId = elementId;
        }

        #endregion

        #region Properties

        public string ElementId { get; }

        #endregion
    }
}