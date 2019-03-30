namespace Bimface.SDK.Entities.Parameters.File
{
    public class CreateAppendFileParameter
    {
        #region Constructors

        public CreateAppendFileParameter(string name, long? length, string sourceId = null)
        {
            Name     = name;
            Length   = length;
            SourceId = sourceId;
        }

        #endregion

        #region Properties

        public long?  Length   { get; }
        public string Name     { get; }
        public string SourceId { get; set; }

        #endregion
    }
}