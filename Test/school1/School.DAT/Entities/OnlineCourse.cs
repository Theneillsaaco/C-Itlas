

using School.DAL.core;

namespace School.DAL.Entities
{
    public partial class OnlineCourse : BaseEntity
    {
        
        public string? Url { get; set; }

        public virtual Course? Course { get; set; }
    }
}