namespace Bimface.SDK.Entities.Core
{
    public class IntegrateSource
    {
        #region Properties

        public string Building  { get; set; }
        public string DatabagId { get; set; }
        public long?  FileId    { get; set; }
        public string FileName  { get; set; }
        public string Floor     { get; set; }
        public float? FloorSort { get; set; }

        /// <summary>
        ///     A name indicating the domain that the <see cref="IntegrateSource" /> belongs to
        /// </summary>
        /// <value>The name of the domain.</value>
        public string Specialty { get; set; }

        public float?   SpecialtySort { get; set; }
        public double[] Transform     { get; set; }

        #endregion
    }
}