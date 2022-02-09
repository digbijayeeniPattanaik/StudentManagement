using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStudentManagementSystem.Models
{

    ////[Table("SubjectEnrollementnts")]
    public class SubjectEnrollment : BaseEntity
    {

        //[Key]
        //public int EnrollId { get; set; }
        [Required]
        ////[ForeignKey("Subject")]
        public int SubjectId { get; set; }
        [Required]
        ////[ForeignKey("Student")]
        public int StudentId { get; set; }
        public virtual Subject Subjects { get; set; }
    }
}
