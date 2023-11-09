using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DemoMVC.Models
// ho va ten do duc tue 2121050190
{
    [Table("Person")]
    public class Person 
    {
        [Key]
        // Thuoc tinh
        public string PersonId { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
    }
}