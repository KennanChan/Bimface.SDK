﻿namespace Bimface.SDK.Entities.Core
{
    public class ElementPropertyOverride
    {
        public string                         KeyToMatch     { get; set; }
        public string                         KeyToOverride  { get; set; }
        public long?[]                        TargetFileIds  { get; set; }
        public ElementPropertyValueOverride[] ValueOverrides { get; set; }
    }
}