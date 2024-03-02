

using School.DAL.core;
using System.ComponentModel.DataAnnotations;

namespace School.DAL.Entities
{
    public partial class OnlineCourse : BaseEntity
    {
        [Key]
        public string? Url { get; set; }

        public virtual Course? Course { get; set; }
    }
}