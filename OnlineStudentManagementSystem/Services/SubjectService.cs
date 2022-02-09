using OnlineStudentManagementSystem.Configuration;
using OnlineStudentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStudentManagementSystem.Services
{
    public class SubjectService : ISubjectService
    {
        private readonly IUnitOfWork _unitOfWork;

        public SubjectService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Subject>> Get()
        {
            return await _unitOfWork.Subject.All();
        }
        public async Task<Subject> GetById(int id)
        {
            return await _unitOfWork.Subject.GetById(id);
        }
        public async Task CreateSubject(Subject subject)
        {
            await _unitOfWork.Subject.Add(subject);
            await _unitOfWork.CompleteAsync();

        }
        public async Task DeleteSubject(int id)
        {
            await _unitOfWork.Subject.Delete(id);
            await _unitOfWork.CompleteAsync();
        }
    }
}

