#region

using System.Collections.Generic;

#endregion

namespace Bimface.SDK.Entities.Core
{
    public class ModelAndView
    {
        #region Properties

        public bool                        Empty     { get; set; }
        public object                      Model     { get; set; }
        public IDictionary<string, object> ModelMap  { get; set; }
        public bool                        Reference { get; set; }
        public string                      Status    { get; set; }
        public View                        View      { get; set; }
        public string                      ViewName  { get; set; }

        #endregion
    }
}