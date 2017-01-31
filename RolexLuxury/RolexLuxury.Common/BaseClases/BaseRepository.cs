using RolexLuxury.Common.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Data.Entity;

namespace RolexLuxury.Common.BaseClases
{
    public abstract class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private DbContext _context;

        public BaseRepository(DbContext context)
        {
            _context = context;
        }

        public DbContext Context
        {
            get
            {
                return _context;
            }

            set
            {
                _context = value;
            }
        }
        public virtual Task<IQueryable<TEntity>> Find(Expression<Func<TEntity, bool>> whereExpression)
        {
            return Task.FromResult(_context.Set<TEntity>().Where(whereExpression));
        }

        public virtual Task<List<TEntity>> Get()
        {
            return Task.FromResult(_context.Set<TEntity>().ToList());            
        }

        public virtual Task<TEntity> Get(int id)
        {
            return Task.FromResult(_context.Set<TEntity>().FirstOrDefault());
        }
    }
}
