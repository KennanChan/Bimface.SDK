using System;
namespace Bimface.SDK.Entities.Parameters
{
    public class FetchAppendFileParameter
    {
        public FetchAppendFileParameter(long? appendFileId)
        {
            AppendFileId = appendFileId;
        }
        public long? AppendFileId { get; }
    }
}
