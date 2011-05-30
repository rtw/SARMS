using System.Collections.Generic;

namespace Sarms.Domain.Core
{
    public class Unit
    {
        public int UnitID { get; set; }
        public string UnitName { get; set; }
        public Lecturer Lecturer { get; set; }
        public Course Course { get; set; }
        public IList<Enrollment> Enrollments { get; set; }
        public IList<Assignment> Assignments { get; set; }

        public Unit()
        {
            Enrollments = new List<Enrollment>();
            Assignments = new List<Assignment>();
        }

        public void ChangeLecturer(Lecturer lecturer)
        {
            Lecturer = lecturer;
        }

        public Enrollment EnrollStudent(Student student)
        {
            var enrollment = new Enrollment();
            enrollment.Unit = this;
            enrollment.Student = student;

            Enrollments.Add(enrollment);
            student.Enrollments.Add(enrollment);

            return enrollment;
        }

        public void AddAssignment(Assignment assignment)
        {
            Assignments.Add(assignment);
        }

        public void RemoveAssignment(Assignment assignment)
        {
            Assignments.Remove(assignment);
        }

        public void ChangeCourse(Course course)
        {
            // Remove from existing course
            if (Course != null)
                Course.RemoveUnit(this);

            // Add to new course
            course.AddUnit(this);
        }
    }
}
