using System;

namespace Bimface.SDK.Entities.Parameters.Share
{
    public class CreateShareParameter
    {
        public int?     ActiveHours  { get; set; }
        public DateTime ExpireDate   { get; set; }
        public long?    FileId       { get; set; }
        public long?    IntegrateId  { get; set; }
        public bool?    NeedPassword { get; set; }
    }
}
