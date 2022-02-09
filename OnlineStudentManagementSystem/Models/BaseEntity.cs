using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineStudentManagementSystem.Models
{
    public class BaseEntity
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
    }
}
