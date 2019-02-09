﻿using System;

namespace Bimface.SDK.Entities.Core
{
    public class InsecureShareLinkEntity
    {
        public string AppKey { get; set; }
        public DateTime ExpireTime { get; set; }
        public bool PasswordProtect { get; set; }
        public long? SourceId { get; set; }
        public string SourceType { get; set; }
        public string Url { get; set; }
    }
}