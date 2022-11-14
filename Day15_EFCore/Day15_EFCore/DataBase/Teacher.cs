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
    [Table("Teachers", Schema = "dbo")]
    public class Teacher
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Teacher Id")]
        public int TeacherId { get; set; }

        [Required]
        [Column(TypeName = "VarChar(100)")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Column(TypeName = "VarChar(100)")]
        [Display(Name = "Last Name")]
        public string? LastName { get; set; }
        public virtual ICollection<Courses> Courses { get; set; }
    }
}
