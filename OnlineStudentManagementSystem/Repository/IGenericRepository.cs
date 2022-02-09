using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStudentManagementSystem.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> All();
        Task<T> GetById(int id);
        Task<bool> Add(T entity);
        void AddOnly(T entity);
        Task<bool> Delete(int id);
        Task<bool> Upsert(T entity);
    }
}