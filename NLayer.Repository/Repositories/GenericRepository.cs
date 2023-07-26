using Microsoft.EntityFrameworkCore;
using Nlayer.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Repositories
{
    internal class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        //readonly ya oluşturulduğu yerde yada constructor da değer atanabilir
        protected readonly AppDbContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        -
        Task IGenericRepository<T>.AddAsync(T entity)
        {
            throw new NotImplementedException();
        }

        Task<bool> IGenericRepository<T>.AddRangeAsync(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        Task<bool> IGenericRepository<T>.AnyAsync(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        Task<bool> IGenericRepository<T>.AnyAsync(T entity)
        {
            throw new NotImplementedException();
        }

        IQueryable<T> IGenericRepository<T>.GetAll(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<T>> IGenericRepository<T>.GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        void IGenericRepository<T>.Remove(T entity)
        {
            throw new NotImplementedException();
        }

        void IGenericRepository<T>.RemoveRange(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        void IGenericRepository<T>.Update(T entity)
        {
            throw new NotImplementedException();
        }

        IQueryable<T> IGenericRepository<T>.Where(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
