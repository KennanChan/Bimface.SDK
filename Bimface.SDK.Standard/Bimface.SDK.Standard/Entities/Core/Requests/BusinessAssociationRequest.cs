using Bimface.SDK.Interfaces.Core;

namespace Bimface.SDK.Entities.Core
{
  public class BusinessAssociationRequest : ICallbackSource, IConfigurable
  {
    #region Properties

    public string Callback { get; set; }
    public object Config { get; set; }
    public long? IntegrateId { get; set; }
    public string Name { get; set; }
    public int? Priority { get; set; }
    public long?[] RuleFileIds { get; set; }

    #endregion
  }
}