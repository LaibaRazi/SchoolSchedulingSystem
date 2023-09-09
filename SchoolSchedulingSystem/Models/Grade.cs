using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolSchedulingSystem.Models
{
    public class Grade
    {
        [Key]
        public int Id { get; set; }
        public string Class { get; set; }
        public string Section { get; set; }
        public int Tutor { get; set; }
        [ForeignKey("Tutor")]
        public virtual Teacher Teacher { get; set; }
    }
}
