using System.ComponentModel.DataAnnotations;

namespace SchoolSchedulingSystem.Models
{
    public class Admin
    {
        [Key]
        public int Admin_id { get; set; }
        public string role { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
}
