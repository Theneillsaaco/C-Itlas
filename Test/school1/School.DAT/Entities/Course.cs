using School.DAL.core;

namespace School.DAL.Entities
{
    public partial class Course : PersonBase
    {
        public Course()
        {
            StudentGrades = new HashSet<StudentGrade>();
            People = new HashSet<Person>();
        }
        
        
        public int Credits { get; set; }
        public int DepartmentId { get; set; }


        public virtual Department Department { get; set; }
        public virtual OnlineCourse OnlineCourse { get; set; }
        public virtual OnsiteCourse OnsiteCourse { get; set; }
        public virtual ICollection<StudentGrade> StudentGrades { get; set; }

        public virtual ICollection<Person> People { get; set; }
    }
}