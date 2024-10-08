﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EFCBasic02.Entities
{
    [Table("Courses")]
    internal class Course
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CourseId { get; set; }

        public DateTime Duration { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(2, MinimumLength = 20)]
        public string Name { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        public Topic Topic { get; set; }

        public ICollection<Stud_Course> courseStudent { get; set; } = new HashSet<Stud_Course>();
        public ICollection<Course_Ins> courseInstructor    { get; set; } = new HashSet<Course_Ins>();

    }
}
