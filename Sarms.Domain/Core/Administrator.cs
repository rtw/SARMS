using System.Collections.Generic;

namespace Sarms.Domain.Core
{
    public class Administrator : Account
    {
        public IList<Report> Reports { get; set; }

        public Administrator()
        {
            Reports = new List<Report>();
        }
    }
}