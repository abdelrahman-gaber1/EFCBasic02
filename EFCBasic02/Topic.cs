using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EFCBasic02
{
    [Table("Topic")]
    internal class Topic
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int topicId { get; set; }

        [Required]
        [Column(TypeName ="varchar")]
        public string Name { get; set; }

        public ICollection<Course> Courses { get; set; } = new HashSet<Course>();
    }
}
