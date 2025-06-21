
using System.ComponentModel.DataAnnotations;

namespace emp_details.Models
{
    public class Employee
    {
        [Key]
        public int Empid { get; set; }
        [Required]
        public string? EmpName { get; set; }
        public double? EmpSalary { get; set; }
        public DateOnly Date_of_joining { get; set; }
    }
}
