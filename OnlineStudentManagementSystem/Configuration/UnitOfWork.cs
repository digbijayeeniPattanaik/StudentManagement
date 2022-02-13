using Microsoft.Extensions.Logging;
using OnlineStudentManagementSystem.Models;
using OnlineStudentManagementSystem.Repository;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStudentManagementSystem.Configuration
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly MyDBContext _context;
        private readonly ILogger _logger;


        public IAdminRepository Admin { get; private set; }
        ////public IAddressCodeRepository AddressCode { get; private set; }
        public ICourseRepository Course { get; private set; }
        public ISubjectRepository Subject { get; private set; }
        public IStudentRepository Student { get; private set; }



        public ISubjectEnrollmentRepository SubjectEnrollment { get; private set; }


        public UnitOfWork(MyDBContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("logs");

            Admin = new AdminRepository(context, _logger);
            ////AddressCode = new AddressCodeRepository(context, _logger);
            Course = new CourseRepository(context, _logger);
            Subject = new SubjectRepository(context, _logger);
            Student = new StudentRepository(context, _logger);
            SubjectEnrollment = new SubjectEnrollmentRepository(context, _logger);
        }

        
        

        ////public async Task CompleteAsync()
        ////{
        ////    await _context.SaveChangesAsync();
        ////}

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public  void Dispose()
        {
            _context.Dispose();
            ////GC.SuppressFinalize(this);
        }

        private Hashtable _repositories;
        public IGenericRepository<T> Repository<T>() where T : class
        {
            if (_repositories == null) _repositories = new Hashtable();

            var type = typeof(T).Name;

            if (!_repositories.ContainsKey(type))
            {
                var repositoryType = typeof(GenericRepository<>);
                var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(T)), _context, _logger);
                _repositories.Add(type, repositoryInstance);
            }

            return (IGenericRepository<T>)_repositories[type];
        }
    }
}