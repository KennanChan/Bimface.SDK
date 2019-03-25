#region

using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.Integrate
{
    public class ListIntegrateElementPropertiesParameter : IntegrateParameter
    {
        #region Constructors

        public ListIntegrateElementPropertiesParameter(long integrateId, string elementId) : base(integrateId)
        {
            ElementId = elementId;
        }

        #endregion

        #region Properties

        public string ElementId { get; }

        #endregion
    }
}