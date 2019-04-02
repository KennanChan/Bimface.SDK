using Bimface.SDK.Attributes;
using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Base;

namespace Bimface.SDK.Entities.Parameters.File
{
    [BimfaceAuth]
    [BimfaceFileHttpRequest(HttpMethods.Post, "/appendFiles")]
    public class CreateAppendFileParameter : HttpParameter
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

        [HttpQueryComponent(Alias = "length")]
        public long? Length { get; }

        [HttpQueryComponent(Alias = "name")]
        public string Name { get; }

        [HttpQueryComponent(Alias = "sourceId")]
        public string SourceId { get; set; }

        #endregion
    }
}