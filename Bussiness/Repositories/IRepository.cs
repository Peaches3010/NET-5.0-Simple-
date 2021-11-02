using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Business.Repositories
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> Entites { get; }

        Task<IEnumerable<T>> GetAllAsync();

        Task<T> GetByIdAsync(object id);

        Task<T> GetByAsync(Expression<Func<T, bool>> filter = null, string includeProperties = "");

        Task<T> AddAsync(T entity);

        Task UpdateAsync(T entity);

        Task DeleteAsync(object id);
    }
}
