using System.Collections.Generic;

namespace Sarms.Domain.Core
{
    public class Unit
    {
        public int UnitCode { get; set; }
        public string UnitName { get; set; }
        public Lecturer Lecturer { get; set; }
        public Course Course { get; set; }
        public IList<Student> Students { get; set; }
        public IList<Assignment> Assignments { get; set; }

        public Unit()
        {
            Students = new List<Student>();
            Assignments = new List<Assignment>();
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);    
        }

        public void RemoveStudent(Student student)
        {
            Students.Remove(student);
        }

        public void ChangeLecturer(Lecturer lecturer)
        {
            Lecturer = lecturer;
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
