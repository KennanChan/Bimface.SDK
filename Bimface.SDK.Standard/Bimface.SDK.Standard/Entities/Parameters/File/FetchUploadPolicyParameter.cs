namespace Bimface.SDK.Entities.Parameters.File
{
    public class FetchUploadPolicyParameter
    {
        #region Constructors

        public FetchUploadPolicyParameter(string name)
        {
            Name = name;
        }

        #endregion

        #region Properties

        public string Name     { get; }
        public string SourceId { get; set; }

        #endregion
    }
}