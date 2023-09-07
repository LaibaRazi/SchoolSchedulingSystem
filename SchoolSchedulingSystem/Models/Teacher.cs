using System.ComponentModel.DataAnnotations;

namespace SchoolSchedulingSystem.Models
{
    public class Teacher
    {
        [Key]
        public int ID_Teacher { get; set; }
        public string TeacherName { get; set; }
        public string HTeacher { get; set; }
        public string u_one { get; set; }
        public string u_two { get; set; }
        public string u_three { get; set; }
        public string u_four { get; set; }
        public string u_five { get; set; }
        public string u_six { get; set; }
        public string u_seven { get; set; }
    }
}
