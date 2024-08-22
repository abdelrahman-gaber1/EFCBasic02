using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCBasic02.Entities
{
    [Table("Stud_Course")]
    internal class Stud_Course
    {
        [Key]
        [Column(Order = 0)]
        public int Stud_Id { get; set; }
        [Key]
        [Column(Order = 1)]
        public int Course_Id { get; set; }

        [Required]
        [Range(1, 200)]
        public int Grade { get; set; }

        public Student student { get; set; }

        public Course course { get; set; }  

    }
}
