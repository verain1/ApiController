using System.ComponentModel.DataAnnotations;
namespace empService.Models
{
    public class Employee //Treat this as a model omly. and not like a model validator
    {
        public int employeeID{get; set;}
        public string employeeName{get; set;}
        public int employeeAge{get; set;}
    }
}