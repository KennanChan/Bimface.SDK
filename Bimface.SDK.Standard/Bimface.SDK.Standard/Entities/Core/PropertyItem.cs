namespace Bimface.SDK.Entities.Core
{
    public class PropertyItem
    {
        #region Properties

        public string Code { get; set; }
        public object Extension { get; set; }
        public string Key { get; set; }
        public string Unit { get; set; }
        public object Value { get; set; }
        public int? ValueType { get; set; }

        #endregion
    }
}