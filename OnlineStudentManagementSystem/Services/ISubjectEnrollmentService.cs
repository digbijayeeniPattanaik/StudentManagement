using OnlineStudentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStudentManagementSystem.Services
{
   public interface ISubjectEnrollmentService
    {
        Task<IEnumerable<SubjectEnrollment>> Get();
        Task<SubjectEnrollment> GetById(int id);
        Task CreateSubjectEnrollment(SubjectEnrollment subjectEnrollment);
        Task DeleteSubjectEnrollment(int id);

    }
}
