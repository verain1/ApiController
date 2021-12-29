
using System.ComponentModel.DataAnnotations;

namespace empService.DTO
{
    public class EmployeeDTO
    {
        public int employeeID{get; set;}
        
        [Required]
        public string employeeName{get; set;}
        
        [Required]
        public int employeeAge{get; set;}
    }
}