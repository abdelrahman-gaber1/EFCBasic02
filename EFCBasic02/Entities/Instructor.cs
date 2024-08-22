using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCBasic02.Entities
{
    [Table("Instructor")]
    internal class Instructor
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int instractorId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        public string Name { get; set; }
        public double Bouns { get; set; }

        [Column(TypeName = "money")]
        [Range(1000, 60000)]
        public double Salary { get; set; }

        [EmailAddress]
        public string? Address { get; set; }

        public double HourRate { get; set; }

        [InverseProperty("Instructors")]
        public Department Department { get; set; }

        [InverseProperty("Instructor")]
        public Department Dept { get; set; }

        public ICollection<Course_Ins> instructorCourse { get; set; } = new HashSet<Course_Ins>();


    }
}
