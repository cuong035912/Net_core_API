using System.ComponentModel.DataAnnotations;

namespace BTTH.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        public string FullName { get; set; }
    }
}