using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStudentManagementSystem.DTO
{
    public class AddressCodeDTO
    {
       
            
        
            [Required]
         
            [MaxLength(50)]
            public string City { get; set; }
            [Required]
          
            [MaxLength(50)]
            public string State { get; set; }
         
            public int ZipCode { get; set; }
            
        }
    }



