using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace TP4_YASSINE.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string first_name{ get; set; }
        public string last_name{ get; set; }
        public int phone_number { get; set; }
        public string university{ get; set; }
        public DateTime timestamp{ get; set; }
        public string course{ get; set; }
    }
}
