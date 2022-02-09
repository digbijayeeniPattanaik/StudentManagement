using OnlineStudentManagementSystem.Configuration;
using OnlineStudentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStudentManagementSystem.Services
{
    public class SubjectEnrollmentService : ISubjectEnrollmentService
    {
        private readonly IUnitOfWork _unitOfWork;

        public SubjectEnrollmentService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<SubjectEnrollment>> Get()
        {
            return await _unitOfWork.SubjectEnrollment.All();
        }
        public async Task<SubjectEnrollment> GetById(int id)
        {
            return await _unitOfWork.SubjectEnrollment.GetById(id);
        }
        public async Task CreateSubjectEnrollment(SubjectEnrollment subjectEnrollment)
        {
            await _unitOfWork.SubjectEnrollment.Add(subjectEnrollment);
            await _unitOfWork.CompleteAsync();

        }
        public async Task DeleteSubjectEnrollment(int id)
        {
            await _unitOfWork.SubjectEnrollment.Delete(id);
            await _unitOfWork.CompleteAsync();
        }

    }
}
