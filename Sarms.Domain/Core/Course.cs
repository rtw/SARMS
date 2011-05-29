#region

using System.Collections.Generic;

#endregion

namespace Sarms.Domain.Core
{
    public class Course
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public bool Active { get; set; }
        public IList<Unit> Units { get; set; }

        public void AddUnit(Unit unit)
        {
            Units.Add(unit);
        }

        public void RemoveUnit(Unit unit)
        {
            Units.Remove(unit);
        }
    }
}