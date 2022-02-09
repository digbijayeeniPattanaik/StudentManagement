using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStudentManagementSystem.Models
{
    ////[Table("Subjects")]
    public class Subject : BaseEntity
    {

        ////[Key]
        ////public int SubjectId { get; set; }
        [Required]
        ////[Column("SubjectName", TypeName = "varchar")]
        public string SubjectName { get; set; }
        [Required]
        ////[Column("Marks")]
        public int Marks { get; set; }
       
       
        public virtual ICollection<SubjectEnrollment> SubjectEnrollments { get; set; }
    }
}
