namespace Bimface.SDK.Entities
{
    public class GeneralResponse<T> : GeneralResponse
    {
        #region Properties

        public new T Data { get; set; }

        #endregion
    }

    public class GeneralResponse
    {
        #region Properties

        public string Code    { get; set; }
        public object Data    { get; set; }
        public string Message { get; set; }

        #endregion
    }
}