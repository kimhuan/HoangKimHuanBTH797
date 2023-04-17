using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaiThucHanh1004.Models
{
    [Table ("Students")]
    public class Student
    {
        [Key]
        public string StudentID { get; set; }
        
        public string FullName { get; set; }
        
        public string Address { get; set; }
        
        public string PhoneNumber { get; set; }
        
    }
}