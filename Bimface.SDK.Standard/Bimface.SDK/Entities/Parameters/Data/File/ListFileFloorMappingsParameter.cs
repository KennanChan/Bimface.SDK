﻿#region

using System.Collections.Generic;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.File
{
    public class ListFileFloorMappingsParameter : FileParameter
    {
        #region Constructors

        public ListFileFloorMappingsParameter(long fileId) : base(fileId)
        {
            FileIds = new List<long?>();
        }

        #endregion

        #region Properties

        public List<long?> FileIds     { get; set; }
        public bool?       IncludeArea { get; set; }
        public bool?       IncludeRoom { get; set; }

        #endregion
    }
}