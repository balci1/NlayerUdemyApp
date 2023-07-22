using System.Linq.Expressions;

namespace Nlayer.Core.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetByIdAsync(int id);
        IQueryable<T> GetAll(Expression<Func<T, bool>> expression);
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
        Task<bool> AnyAsync(T entity);//memoriye ekliyor uzun süren bir işlem var o yüzden async
        Task<bool> AnyRangeAsync(IEnumerable<T> entities);
        void Update(T entity);//burda zaten takip edilen bir kaydı update ediyor sadece  o yüzden async olması gerekmez
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}
