#region

using Bimface.SDK.Attributes;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.File;
using Bimface.SDK.Requests.Base;

#endregion

namespace Bimface.SDK.Requests.File
{
    [BimfaceAuth]
    internal class ListFilesRequest : BimfaceFileRequest
    {
        #region Constructors

        public ListFilesRequest(ListFilesParameter parameter) : base(HttpMethods.Get, "/files")
        {
            AddDateQuery("endTime", parameter.EndTime);
            AddNullableQuery("offset", parameter.Offset);
            AddNullableQuery("rows", parameter.Rows);
            AddQuery("scope", parameter.Scope);
            AddDateQuery("startTime", parameter.StartTime);
            AddQuery("status", parameter.Status);
            AddQuery("suffix", parameter.Suffix);
        }

        #endregion
    }
}