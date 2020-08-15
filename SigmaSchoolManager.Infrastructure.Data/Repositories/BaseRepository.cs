using Microsoft.EntityFrameworkCore;
using SigmaSchoolManager.Domain.Interfaces;
using SigmaSchoolManager.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace SigmaSchoolManager.Infrastructure.Data.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity: class
    {
        internal SigmaSchoolManagerContext _context;
        internal DbSet<TEntity> _dbSet;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public BaseRepository(SigmaSchoolManagerContext context)
        {
            this._context = context;
            this._dbSet = context.Set<TEntity>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        public virtual void Delete(TEntity entity)
        {
            if(_context.Entry(entity).State == EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }
            _dbSet.Remove(entity);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public virtual void Delete(object id)
        {
            TEntity entityToDelete = _dbSet.Find(id);
            this.Delete(entityToDelete);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="orderBy"></param>
        /// <param name="includeProperties"></param>
        /// <returns></returns>
        public virtual IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "")
        {
            IQueryable<TEntity> query = _dbSet;

            if(filter != null)
            {
                query.Where(filter);
            }

            if(includeProperties != null)
            {
                foreach (var includeProperty in includeProperties.Split
                            (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }
            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual TEntity GetById(object id)
        {
            return _dbSet.Find(id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="query"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public virtual IEnumerable<TEntity> GetWithRawSql(string query, params object[] parameters)
        {
            return _dbSet.FromSqlRaw(query, parameters: parameters).ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        public virtual void Insert(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        public virtual void Update(TEntity entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
