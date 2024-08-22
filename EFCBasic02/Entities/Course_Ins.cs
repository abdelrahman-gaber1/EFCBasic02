using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EFCBasic02.Entities
{
    [Table("Course_Ins")]
    internal class Course_Ins
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Inst_Id { get; set; }

        [Required]
        public int Course_ID { get; set; }

        [Column(TypeName = "float")]
        public double Evaluate { get; set; }

        public Course course  { get; set; }

        public Instructor instructor { get; set; }
    }
}
