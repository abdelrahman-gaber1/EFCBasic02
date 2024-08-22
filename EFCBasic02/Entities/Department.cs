using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCBasic02.Entities
{
    [Table("Department")]
    internal class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DeptId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        public string Name { get; set; }

        public DateTime HiringDate { get; set; }

        public ICollection<Student> Students { get; set; } = new HashSet<Student>();

        [InverseProperty("Department")]

        public ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();

        [InverseProperty("Dept")]
        public Instructor Instructor { get; set; }

    }
}
