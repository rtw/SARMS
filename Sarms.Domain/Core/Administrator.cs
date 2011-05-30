using System.Collections.Generic;

namespace Sarms.Domain.Core
{
    public class Administrator : Account
    {
        public int AdministratorID { get; set; }
        public IList<Report> Reports { get; set; }

        public Administrator()
        {
            Reports = new List<Report>();
        }
    }
}