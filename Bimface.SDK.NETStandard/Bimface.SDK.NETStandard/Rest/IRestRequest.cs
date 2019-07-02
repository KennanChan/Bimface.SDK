using System;
using System.Collections.Generic;
using System.Text;

namespace Bimface.SDK.NETStandard.Rest
{
    public interface IRestRequest
    {
        void AddBody(object body);
        void AddHeader(string key, string value);
        void AddQuery(string field, string value);
    }
}
