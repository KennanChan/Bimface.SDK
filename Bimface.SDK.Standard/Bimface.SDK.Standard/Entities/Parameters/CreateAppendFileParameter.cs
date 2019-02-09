using System;
namespace Bimface.SDK.Entities.Parameters
{
    public class CreateAppendFileParameter
    {
        public CreateAppendFileParameter(string name, long? length)
        {
            Name = name;
            Length = length;
        }

        public long? Length { get; }
        public string Name { get; }
        public string SourceId { get; set; }
    }
}