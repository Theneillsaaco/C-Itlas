
using School.DAL.core;

namespace School.DAL.Entities
{
    public partial class OfficeAssignment : BaseEntity
    {
        public int InstructorId { get; set; }
        public byte[] Timestamp { get; set; }

        public virtual Person? Instructor { get; set; }
    }
}