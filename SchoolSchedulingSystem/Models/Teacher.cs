using System.ComponentModel.DataAnnotations;

namespace SchoolSchedulingSystem.Models
{
    public class Teacher
    {
        [Key]
        public int ID_Teacher { get; set; }
        public string Tutor { get; set; }
        public string Subj_of_Teacher { get; set; }
      
    }
}
