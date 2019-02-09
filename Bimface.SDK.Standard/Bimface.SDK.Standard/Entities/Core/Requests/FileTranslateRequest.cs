using System.Collections.Generic;

namespace Bimface.SDK.Entities.Core
{
    public class FileTranslateRequest
    {
        public string Callback { get; set; }
        public IDictionary<string,string> Config { get; set; }
        public int? Priority { get; set; }
        public TranslateSource Source { get; set; }
    }
}
