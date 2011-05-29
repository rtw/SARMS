#region

using System;

#endregion

namespace Sarms.Domain.Core
{
    public class Report
    {
        public int ReportID { get; set; }
        public string ReportName { get; set; }
        public DateTime LastViewdDate { get; set; }
        public string LastViewedBy { get; set; }
    }
}