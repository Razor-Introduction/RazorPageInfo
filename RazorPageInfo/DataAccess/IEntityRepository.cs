using System.Linq.Expressions;
using System.Security.Principal;

namespace RazorPageInfo.DataAccess
{
    public interface IEntityRepository<T> where T : class, new()
    {
        Task<T> Get(Expression<Func<T, bool>> filter);
        Task<IEnumerable<T>> GetList(Expression<Func<T, bool>> filter = null);
        Task Add(T entity);
        Task Update(T entity);
        Task Delete(T entity);
    }
}
