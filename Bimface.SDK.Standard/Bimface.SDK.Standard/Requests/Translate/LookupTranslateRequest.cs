﻿using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Translate;
using Bimface.SDK.Requests.Base;

namespace Bimface.SDK.Requests.Translate
{
    internal class LookupTranslateRequest : BimfaceApiRequest
    {
        public LookupTranslateRequest(LookupTranslateParameter parameter) : base(HttpMethods.Get, "/translate")
        {
            AddNullableQuery("fileId", parameter.FileId);
        }
    }
}