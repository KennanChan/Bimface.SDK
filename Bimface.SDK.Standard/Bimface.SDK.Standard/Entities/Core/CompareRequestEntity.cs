using Bimface.SDK.Interfaces.Core;

namespace Bimface.SDK.Entities.Core
{
    public class CompareRequestEntity : ICallbackSource, IConfigurable
    {
        #region Properties

        public string Callback { get; set; }
        public string ComparedEntityType { get; set; }
        public object Config { get; set; }
        public long? FollowingId { get; set; }
        public string Name { get; set; }
        public long? PreviousId { get; set; }
        public int? Priority { get; set; }
        public string SourceId { get; set; }

        #endregion
    }
}