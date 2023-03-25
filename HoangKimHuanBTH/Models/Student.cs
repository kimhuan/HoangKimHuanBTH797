using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HoangKimHuanBTH.Models
{
    [Table ("Students")]
    public class Student
    {
        [Key]
        public string StudentCode { get; set; }
        
         public string FullName { get; set; }

         public string Address { get; set; }
                  
    }
}