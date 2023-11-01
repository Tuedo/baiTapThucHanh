using System.ComponentModel.DataAnnotations;
namespace DemoMVC.Models
// do duc tue 2121050190
{
    public class Student
    {
        [Required]
        public string StudentID{ get; set; }
        [Required]
        public string FullName{ get; set; }
    
    }
}