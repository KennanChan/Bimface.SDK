﻿#region

using Bimface.SDK.Attributes;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.Compare
{
    [BimfaceAuth]
    public class LookupCompareChangesParameter : CompareParameter
    {
        #region Constructors

        public LookupCompareChangesParameter(long compareId) : base(compareId)
        {
        }

        #endregion

        #region Properties

        public string FollowingElementId { get; set; }
        public long?  FollowingFileId    { get; set; }
        public string PreviousElementId  { get; set; }
        public long?  PreviousFileId     { get; set; }

        #endregion
    }
}