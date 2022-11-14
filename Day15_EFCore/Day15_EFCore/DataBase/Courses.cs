using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day15_EFCore.DataBase
{
    [Table("Courses", Schema = "dbo")]
    public class Courses
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Course Id")]
        public int CourseId { get; set; }

        [Required]
        [Column(TypeName = "VarChar(200)")]
        [Display(Name = "Course Name")]
        public string CourseName { get; set; }

        public int TeacherId { get; set; }
        public virtual Teacher Teachers { get; set; }
        public virtual ICollection<StudentCourses> StudentCourses { get; set; }
    }
}
