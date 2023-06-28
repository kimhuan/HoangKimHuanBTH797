using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BaiThucHanh2404.Models
{
    [Table ("Employees")]
    public class Employee
    {
        [Key]
        [Display (Name = "Mã nhân viên")]
        public string EmployeeID{get; set;}

        [Display (Name = "Tên nhân viên")]
        public string EmployeeName{get; set;}

        [Display (Name = "Số điện thoại")]
        public string PhoneNumber{get;set;}

    }
}