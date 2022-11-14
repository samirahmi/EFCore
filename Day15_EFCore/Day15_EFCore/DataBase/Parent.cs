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
    [Table("Parent", Schema = "dbo")]
    public class Parent
    {
        [Key]
        public Guid ParentId { get; set; }

        [Required]
        [Column(TypeName = "VarChar(200)")]
        [Display(Name = "Parent Name")]
        public string ParentName { get; set; }
        public string Address { get; set; }
    }
}
