
using School.DAL.Entities;

namespace School.DAL.core
{
    public abstract class BaseEntity
    {
        #region "test"
        public string? Location { get; set; }
        public string? Days { get; set; }
        public int CourseId { get; set; }
        #endregion
        public DateTime? HireDate { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        public int CreationUser { get; set; }
        public int? UserMod { get; set; }
        public int? UserDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool Deleted { get; set; }
    }
}
    

