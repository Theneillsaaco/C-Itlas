using School.DAL.Context;
using School.DAL.Entities;
using School.DAL.Exceptions;
using School.DAL.Interfaces;
using School.DAL.Enums;


namespace School.DAL.Dao 
{
    public class DaoCourse : IDaoCourse
    {
        private readonly SchoolContext context;
        public DaoCourse(SchoolContext context)
        {
            this.context = context;
        }

        public bool ExistsCourse(Func<Course, bool> filter)
        {
            return this.context.Course.Any(filter);
        }

        public Course GetCourse(int Id)
        {
            return this.context.Course.Find(Id);
        }

        public List<Course> GetCourses()
        {
            return this.context.Course.ToList();
        }

        public List<Course> GetCourses(Func<Course, bool> filter)
        {
            return this.context.Course.Where(filter).ToList();
        }

        public void RemoveCourse(Course course)
        {
            Course courseToRemove = this.GetCourse(course.CourseId);

            courseToRemove.Deleted = course.Deleted;
            courseToRemove.DeletedDate = course.DeletedDate;
            courseToRemove.UserDeleted = course.UserDeleted;

            this.context.Course.Update(courseToRemove);

            this.context.SaveChanges();

        }

        public void SaveCourse(Course course)
        {
            string message = string.Empty;

            if (!IsCourseValid(course, ref message, Operations.Save))
                throw new DaoCourseException(message);

            

            this.context.Course.Add(course);
            this.context.SaveChanges();
        }

        public void UpdateCourse(Course course)
        {
            string message = string.Empty;

            if (!IsCourseValid(course, ref message, Operations.Update))
                throw new DaoCourseException(message);

            Course courseToUpdate = this.GetCourse(course.CourseId);

            courseToUpdate.ModifyDate = course.ModifyDate;
            courseToUpdate.Name = course.Name;
            courseToUpdate.UserMod = course.UserMod;

            this.context.Course.Add(courseToUpdate);
            this.context.SaveChanges();
        }

        private bool IsCourseValid(Course course, ref string message, Operations operations)
        {
            bool result = false;

            if (string.IsNullOrEmpty(course.Title))
            {
                message = "El titulo del course es requerido.";
                return true;
            }
            if (course.Title.Length > 100)
            {
                message = "El titulo es demaciado largo, El limite es 100 caracteres.";
                return true;
            }

            
            if (course.Credits == 0)
            {
                message = "El credito no puede ser 0.";
                return true;
            }
            if (operations == Operations.Save)
            {
                if (this.ExistsCourse(cd => cd.Title == course.Title))
                {
                    message = "El nombre ya existe.";
                    return true;
                }
            }
            else
                result = true;

            return result;
        }
    }
}
