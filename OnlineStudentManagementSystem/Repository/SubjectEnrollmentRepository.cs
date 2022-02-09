using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using OnlineStudentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStudentManagementSystem.Repository
{
    public class SubjectEnrollmentRepository : GenericRepository<SubjectEnrollment>, ISubjectEnrollmentRepository
    {
        public SubjectEnrollmentRepository(MyDBContext context, ILogger logger) : base(context, logger)
        {
        }
        public override async Task<IEnumerable<SubjectEnrollment>> All()
        {
            try
            {
                return await dbSet.ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} All function error", typeof(SubjectEnrollmentRepository));
                return new List<SubjectEnrollment>();
            }
        }
        public override async Task<bool> Upsert(SubjectEnrollment entity)
        {
            try
            {
                var existingUser = await dbSet.Where(x => x.EnrollId == entity.EnrollId)
                                                    .FirstOrDefaultAsync();

                if (existingUser == null)
                    return await Add(entity);

                existingUser.StudentId = entity.StudentId;
                existingUser.SubjectId = entity.SubjectId;
                


                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} Upsert function error", typeof(SubjectEnrollmentRepository));
                return false;
            }
        }

        public override async Task<bool> Delete(int id)
        {
            try
            {
                var exist = await dbSet.Where(x => x.EnrollId == id)
                                        .FirstOrDefaultAsync();

                if (exist == null) return false;

                dbSet.Remove(exist);

                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} Delete function error", typeof(SubjectEnrollmentRepository));
                return false;
            }
        }
    }
}
