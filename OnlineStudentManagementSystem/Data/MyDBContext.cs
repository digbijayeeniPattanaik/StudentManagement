using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStudentManagementSystem.Models
{
    public class MyDBContext:DbContext
    {
       public MyDBContext(DbContextOptions<MyDBContext>options):base(options)
        { }
           



        public DbSet<AddressCode> AddressCodes { get; set; }
            public DbSet<Subject> Subjects { get; set; }
            public DbSet<Course> Courses { get; set; }
            public DbSet<Admin> Admins { get; set; }
            public DbSet<Student> Students { get; set; }
            public DbSet<SubjectEnrollment> SubjectEnrollments { get; set; }
        }
}
