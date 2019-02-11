namespace Bimface.SDK.Entities.Parameters
{
    public class CreateAppendFileParameter
    {
        #region Constructors

        public CreateAppendFileParameter(string name, long? length)
        {
            Name = name;
            Length = length;
        }

        #endregion

        #region Properties

        public long? Length { get; }
        public string Name { get; }
        public string SourceId { get; set; }

        #endregion
    }
}