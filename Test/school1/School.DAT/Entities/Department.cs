﻿using School.DAL.core;

namespace School.DAL.Entities
{
    public partial class Department : PersonBase
    {
        public Department()
        {
            Courses = new HashSet<Course>();
        }

        public int DepartmentId { get; set; }
        public decimal Budget { get; set; }
        public DateTime StartDate { get; set; }
        public int? Administrator { get; set; }


        public virtual ICollection<Course> Courses { get; set; }
    }
}