using AgroMagCore.IRepositories;
using AgroMagDatabase.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroMagCore.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected AgroMagDbContext context;

        protected DbSet<T> dbSet;

        protected ILogger logger;

        public GenericRepository(
            AgroMagDbContext context,
            ILogger logger)
        {
            this.context = context;
            this.logger = logger;
        }

        public virtual async Task<bool> Add(T entity)
        {
            await dbSet.AddAsync(entity);
            return true;
        }

        public virtual Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<IEnumerable<T>> GetAll()
        {
            return await dbSet.ToListAsync();
        }

        public virtual async Task<T> GetById(int id)
        {
            return await dbSet.FindAsync(id);
        }

        public virtual Task<bool> Upsert(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
