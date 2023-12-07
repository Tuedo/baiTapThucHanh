using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMVC.Models
// do duc tue 2121050190
{
    
    public class Student 
    {
    [Key]
    [Required(ErrorMessage = "Mã Sinh Viên không được để trống")]
    public string? StudentID {get;set;}
    
    public string? FullName { get; set; }
    public string? Address { get; set; }
   
     public string? FacultyID { get; set; }
    [ForeignKey("FacultyID")]
    public Faculty? Faculty { get; set; }   
    
    }
}