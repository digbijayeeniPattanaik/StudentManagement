using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using OnlineStudentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStudentManagementSystem.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected MyDBContext context;
        internal DbSet<T> dbSet;
        protected readonly ILogger _logger;

        public GenericRepository(MyDBContext context, ILogger logger)
        {
            this.context = context;
            this.dbSet = context.Set<T>();
            this._logger = logger;

        }

        public virtual Task<IEnumerable<T>> All()
        {
            throw new NotImplementedException();
        }

        public virtual async Task<T> GetById(int id)
        {
            return await dbSet.FindAsync(id);
        }

        public virtual async Task<bool> Add(T entity)
        {
            await dbSet.AddAsync(entity);
            return true;
        }

        public virtual  Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public virtual Task<bool> Upsert(T entity)
        {
            throw new NotImplementedException();
        }


    }
}