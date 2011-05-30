using System.Collections.Generic;

namespace Sarms.Domain.Core
{
    public class Student : Account
    {
        public int StudentID { get; set; }
        public string Address { get; set; }
        public string Suburb { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string Postcode { get; set; }
        public Course Course { get; set; }
        public IList<Enrollment> Enrollments { get; set; }
        public int EnrolmentStatus { get; private set; }

        public Student()
        {
            Enrollments = new List<Enrollment>();
        }

        public void ChangeEnrollStatus(int status)
        {
            EnrolmentStatus = status;
        }
    }
}