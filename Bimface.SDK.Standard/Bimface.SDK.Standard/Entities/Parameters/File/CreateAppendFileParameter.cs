#region

using Bimface.SDK.Attributes;
using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.File
{
    [BimfaceAuth]
    [BimfaceFileHttpRequest(HttpMethods.Post, "/appendFiles")]
    public class CreateAppendFileParameter : HttpParameter
    {
        #region Constructors

        public CreateAppendFileParameter(string name, long length)
        {
            Name   = name;
            Length = length;
        }

        #endregion

        #region Properties

        [HttpQueryComponent]
        public long Length { get; }

        [HttpQueryComponent]
        public string Name { get; }

        [HttpQueryComponent]
        public string SourceId { get; set; }

        #endregion
    }
}