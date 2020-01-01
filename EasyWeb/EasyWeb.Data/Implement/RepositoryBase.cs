using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace EasyWeb.Data
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private DbSet<T> _dbSet;
        private readonly EasyWebContext _dbContext;

        #region Constructor
        protected RepositoryBase(IDbFactory dbFactory)
        {
            DbFactory = dbFactory;
            _dbSet = DbContext.Set<T>();
        }
        #endregion

        #region Properties
        protected EasyWebContext DbContext
        {
            get
            {
                return _dbContext ?? (DbFactory.Init());
            }
        }
        protected IDbFactory DbFactory { get; private set; }
        #endregion

        #region Implement
        public void AddItem(T entity)
        {
            _dbSet.Add(entity);
        }

        public void AddItems(IEnumerable<T> entities)
        {
            _dbSet.AddRange(entities);
        }

        public void DeleteItem(int id)
        {
            T entity = FindItemById(id);
            _dbSet.Remove(entity);
        }

        public void DeleteItems(IEnumerable<T> entities)
        {
            _dbSet.RemoveRange(entities);
        }

        public T FindItemById(int id)
        {
            return _dbSet.Find(id);
        }

        public IEnumerable<T> GetDataPaging(Expression<Func<T, bool>> where, int total, int currentPage, int pageSize, string[] includes = null)
        {
            IQueryable<T> query = _dbSet.Where(where);
            if (includes != null && includes.Length > 0)
            {
                foreach (string navigation in includes)
                {
                    query.Include(navigation);
                }
            }
            int skip = (currentPage - 1) * pageSize;
            return query.Skip(skip).Take(pageSize).ToList();
        }

        public T GetItem(Expression<Func<T, bool>> condition)
        {
            return _dbSet.Where(condition).SingleOrDefault();
        }

        public IEnumerable<T> GetItems()
        {
            return _dbSet.ToList();
        }

        public IEnumerable<T> GetItems(Expression<Func<T, bool>> condition)
        {
            return _dbSet.Where(condition);
        }

        public void UpdateItem(T entity)
        {
            DbContext.Attach(entity);
            DbContext.Entry(entity).State = EntityState.Modified;
        }
        #endregion
    }
}
