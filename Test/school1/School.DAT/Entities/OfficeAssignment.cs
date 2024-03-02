
using School.DAL.core;
using System.ComponentModel.DataAnnotations;

namespace School.DAL.Entities
{
    public partial class OfficeAssignment : BaseEntity
    {
        [Key]
        public int InstructorId { get; set; }
        public byte[] Timestamp { get; set; }

        public virtual Person? Instructor { get; set; }
    }
}