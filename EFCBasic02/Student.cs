using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCBasic02
{
    [Table("Students")]
    internal class Student
    {

        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentId { get; set; }
        
        [Required]
        [Column(TypeName ="nvarchar")]
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        
        [NotMapped]
        [Range(18, 60)]
        public int? Age { get; set; }
        
        //[ForeignKey("AnyName")]
        public Department Department { get; set; }
    }
}
