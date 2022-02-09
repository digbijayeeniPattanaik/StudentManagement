using OnlineStudentManagementSystem.Repository;
using System.Threading.Tasks;

namespace OnlineStudentManagementSystem.Configuration
{
    public interface IUnitOfWork
    {

        IAdminRepository Admin { get; }
        IAddressCodeRepository AddressCode { get; }
       
        ICourseRepository Course { get; }
        ISubjectRepository Subject { get; }
        IStudentRepository Student { get; }
        ISubjectEnrollmentRepository SubjectEnrollment { get; }
        Task CompleteAsync();



        void Dispose();
    }
}
