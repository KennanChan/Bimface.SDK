using Bimface.SDK.Attributes;
using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Base;

namespace Bimface.SDK.Entities.Parameters.File
{
    [BimfaceAuth]
    [BimfaceFileHttpRequest(HttpMethods.Get, "/support")]
    public class ListSupportFileTypesParameter : HttpParameter
    {
    }
}
