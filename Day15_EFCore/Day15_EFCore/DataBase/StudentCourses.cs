using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_EFCore.DataBase
{
    [Table("StudentCourses", Schema = "dbo")]
    public class StudentCourses
    {
        public int StudentId { get; set; }
        public virtual Student Students { get; set; }
        public int CourseId { get; set; }
        public virtual Courses Courses { get; set; }
    }
}
