using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMVC.Models
// do duc tue 2121050190
{
    [Table("Person")]
    public class Person
    {
        [Key]
       
        public string PersonID { get; set;}
        public  string FullName { get; set;}
        public  string Address { get; set;}
        
    
    }
}