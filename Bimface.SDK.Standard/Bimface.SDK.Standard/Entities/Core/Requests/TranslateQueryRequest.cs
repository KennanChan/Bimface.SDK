#region

using System;
using Bimface.SDK.Entities.Core.Common;

#endregion

namespace Bimface.SDK.Entities.Core.Requests
{
    public class TranslateQueryRequest
    {
        #region Properties

        public string           AppKey    { get; set; }
        public DateTime         EndDate   { get; set; } = DateTime.Now;
        public long?            FileId    { get; set; }
        public string           FileName  { get; set; }
        public int?             PageNo    { get; set; } = 1;
        public int?             PageSize  { get; set; } = 30;
        public string           SortType  { get; set; }
        public string           SourceId  { get; set; }
        public DateTime         StartDate { get; set; }
        public TranslateStatus? Status    { get; set; }
        public string           Suffix    { get; set; }

        #endregion
    }
}