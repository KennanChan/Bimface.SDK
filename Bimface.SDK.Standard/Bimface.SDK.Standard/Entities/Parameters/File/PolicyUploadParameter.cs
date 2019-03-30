namespace Bimface.SDK.Entities.Parameters.File
{
    public class PolicyUploadParameter
    {
        #region Constructors

        public PolicyUploadParameter(string name, string sourceId = null)
        {
            Name     = name;
            SourceId = sourceId;
        }

        #endregion

        #region Properties

        public string Name { get; }

        public string SourceId { get; set; }

        #endregion
    }
}