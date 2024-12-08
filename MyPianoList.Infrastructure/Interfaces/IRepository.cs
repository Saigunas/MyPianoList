using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

/// Initially taken from https://github.com/neozhu/CleanArchitectureWithBlazorServer
/// Heavily modified

namespace MyPianoList.Infrastructure.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<T> AddAsync(T entity);
        Task<bool> UpdateAsync(object id, T entity);

        Task<bool> RemoveByIdAsync(object id);
        bool Remove(T entity);
        bool Remove(Expression<Func<T, bool>> where);

        Task<T?> GetByIdAsync(object id);
        Task<T?> GetAsync(Expression<Func<T, bool>> where);
        IEnumerable<T> GetMany(Expression<Func<T, bool>> where);
        IEnumerable<T> GetAll();

        Task SaveAsync();
        void Save();
        Task<int> Count(Expression<Func<T, bool>> where);
        Task<int> Count();
    }
}
