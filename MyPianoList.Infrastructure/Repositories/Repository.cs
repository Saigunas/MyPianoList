using Microsoft.EntityFrameworkCore;
using MyPianoList.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

/// Initially taken from https://github.com/neozhu/CleanArchitectureWithBlazorServer
/// Heavily modified

namespace MyPianoList.Infrastructure.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbContext _context;
        protected DbSet<T> _entities;

        public Repository(DbContext context)
        {
            _context = context;
            _entities = context.Set<T>();
        }

        protected virtual DbSet<T> Entities
        {
            get
            {
                if (_entities == null)
                    _entities = _context.Set<T>();

                return _entities;
            }
        }

        public async Task<T> AddAsync(T entity)
        {
            await Entities.AddAsync(entity);
            return entity;
        }

        public async Task<bool> UpdateAsync(object id, T entity)
        {
            T? exist = await Entities.FindAsync(id);

            if (exist == null)
            {
                return false;
            }

            _context.Entry(exist).CurrentValues.SetValues(entity);
            return true;
        }


        public async Task<bool> RemoveByIdAsync(object id)
        {
            var entity = await Entities.FindAsync(id);
            if (entity == null)
                return false;

            Entities.Remove(entity);
            return true;
        }

        public bool Remove(T entity)
        {
            Entities.Remove(entity);
            return true;
        }

        public bool Remove(Expression<Func<T, bool>> where)
        {
            var entities = Entities.Where(where);
            Entities.RemoveRange(entities);
            return true;
        }


        public async Task<T?> GetByIdAsync(object id)
        {
            return await Entities.FindAsync(id);
        }
        public async Task<T?> GetAsync(Expression<Func<T, bool>> where)
        {
            return await Entities.FirstOrDefaultAsync(where);
        }
        public virtual IEnumerable<T> GetAll()
        {
            return Entities;
        }
        public virtual IEnumerable<T> GetMany(Expression<Func<T, bool>> where)
        {
            return Entities.Where(where);
        }


        public virtual void Save()
        {
            _context.SaveChanges();
        }
        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }


        public virtual async Task<int> Count()
        {
            return await Entities.CountAsync();

        }
        public virtual async Task<int> Count(Expression<Func<T, bool>> where)
        {
            return await Entities.CountAsync(where);

        }
    }
}
