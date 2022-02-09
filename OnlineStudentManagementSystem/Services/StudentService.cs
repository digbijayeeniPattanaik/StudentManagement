using OnlineStudentManagementSystem.Configuration;
using OnlineStudentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStudentManagementSystem.Services
{
  
        public class StudentService : IStudentService
        {
            private readonly IUnitOfWork _unitOfWork;

            public StudentService(IUnitOfWork unitOfWork)
            {
                this._unitOfWork = unitOfWork;
            }

            public async Task<IEnumerable<Student>> Get()
            {
                return await _unitOfWork.Student.All();
            }
            public async Task<Student> GetById(int id)
            {
                return await _unitOfWork.Student.GetById(id);
            }
            public async Task CreateStudent(Student student)
            {
                await _unitOfWork.Student.Add(student);
                await _unitOfWork.CompleteAsync();

            }
            public async Task DeleteStudent(int id)
            {
                await _unitOfWork.Student.Delete(id);
                await _unitOfWork.CompleteAsync();
            }

        }

    }

