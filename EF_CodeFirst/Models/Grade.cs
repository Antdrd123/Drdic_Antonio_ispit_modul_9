using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EF_CodeFirst.Models
{
    public class Grade
    {
        [Key]
        public int GradeID { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string GradeName { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string Section { get; set; }

        
        [ForeignKey("StudentId")]
        public Student Student { get; set; }
        public int StudentId { get; set; }

    }
}
