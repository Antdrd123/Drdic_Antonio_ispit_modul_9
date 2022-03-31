using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_CodeFirst.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }

        [Column(TypeName = "nchar(200)")]
        public string StudentName { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime DateOfBirth { get; set; }

        [Column(TypeName = "decimal")]
        public decimal Height { get; set; }

        [Column(TypeName = "float")]
        public float Weight { get; set; }
    }
}
