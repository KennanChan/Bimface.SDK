namespace Bimface.SDK.Entities.Parameters
{
    public class ListElementMaterialsParameter : FileParameter
    {
        #region Constructors

        public ListElementMaterialsParameter(long? fileId, string elementId) : base(fileId)
        {
            ElementId = elementId;
        }

        #endregion

        #region Properties

        public string ElementId { get; }

        #endregion
    }
}