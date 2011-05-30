namespace Sarms.Domain.Core
{
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public Unit Unit { get; set; }
        public Student Student { get; set; }
    }
}
