using System.ComponentModel.DataAnnotations;

namespace SchoolSchedulingSystem.Models
{
    public class Teacher
    {
        [Key]
        public int ID_Teacher { get; set; }
        public string TeacherName { get; set; }
        public string HTeacher { get; set; }
        public int u_one { get; set; }
        public int u_two { get; set; }
        public int u_three { get; set; }
        public int u_four { get; set; }
        public int u_five { get; set; }
        public int u_six { get; set; }
        public int u_seven { get; set; }
    }
}
