using School.DAL.Entities;

namespace School.DAL.Interfaces
{
    public interface IDaoCourse
    {
        void SaveCourse(Course course);
        void UpdateCourse(Course course);
        void RemoveCourse(Course course);
        Course GetCourse(int Id);
        List<Course> GetCourses();
        List<Course> GetCourses(Func<Course, bool> filter);
        bool ExistsCourse(Func<Course, bool> filter);
    }
}
