

using School.DAL.core;
using System.ComponentModel.DataAnnotations;

namespace School.DAL.Entities
{
    public partial class OnsiteCourse : BaseEntity
    {

        [Key]
        public DateTime Time { get; set; }

        public virtual Course? Course { get; set; }
    }
}