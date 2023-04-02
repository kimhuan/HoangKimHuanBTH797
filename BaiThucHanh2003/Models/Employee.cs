using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BaiThucHanh2003.Models
{
    [Table ("Employees")]
    public class Employee
    {
        [Key]
        public string EmployeeID{get; set;} = default!;
        public string EmployeeName{get; set;}
        public string PhoneNumber{get;set;}

    }
}