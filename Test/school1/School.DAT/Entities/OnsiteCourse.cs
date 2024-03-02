

using School.DAL.core;

namespace School.DAL.Entities
{
    public partial class OnsiteCourse : BaseEntity
    {


        public DateTime Time { get; set; }

        public virtual Course? Course { get; set; }
    }
}