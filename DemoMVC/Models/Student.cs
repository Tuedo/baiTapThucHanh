using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DemoMVC.Models
// do duc tue 2121050190
{
    [Table("Students")]
    public class Student
    {
        // [Required]
        public string StudentID{ get; set; }
        // [Required]
        public string FullName{ get; set; }
    
    }
}