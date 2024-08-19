using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCBasic02
{
    [Table("Stud_Course")]
    internal class Stud_Course
    {
        public int Stud_Id { get; set; }

        public int Course_Id { get; set; }

        [Required]
        [Range(1, 200)]
        public int Grade { get; set; }
    }
}
