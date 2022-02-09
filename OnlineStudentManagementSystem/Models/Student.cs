using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStudentManagementSystem.Models
{
    [Table("Students")]
    public class Student
    {

        [Key]
        public int StudentId { get; set; }
        [Column("StudentName", TypeName = "varchar")]
        [MaxLength(50)]
        [Required]
        public string StudentName { get; set; }
        [Required]
        [ForeignKey("Course")]
        public int CourseId { get; set; }
        [Required]
        [ForeignKey("AddressCode")]
        public int AddressCodeId { get; set; }
       
      
        [Required]
        public DateTime DOB { get; set; }



        //navigation property
        public virtual AddressCode AddressCodes { get; set; }
        public virtual Course Courses { get; set; }

        public virtual ICollection<SubjectEnrollment> SubjectEnrollments { get; set; }
    }
}
