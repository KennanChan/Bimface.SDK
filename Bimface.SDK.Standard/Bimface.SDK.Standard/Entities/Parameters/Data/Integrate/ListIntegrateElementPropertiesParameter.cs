#region

using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.Integrate
{
    public class ListIntegrateElementPropertiesParameter : IntegrateParameter
    {
        public ListIntegrateElementPropertiesParameter(long integrateId,string elementId) : base(integrateId)
        {
            ElementId = elementId;
        }

        public string ElementId { get; }
    }
}