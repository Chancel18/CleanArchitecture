using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace SigmaSchoolManager.Domain.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IRepository<TEntity> where TEntity: class
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        void Delete(TEntity entity);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        void Delete(object id);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="orderBy"></param>
        /// <param name="includeProperties"></param>
        /// <returns></returns>
        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null,
        Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
        string includeProperties = "");

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TEntity GetById(object id);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="query"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        IEnumerable<TEntity> GetWithRawSql(string query, params object[] parameters);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        void Insert(TEntity entity);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        void Update(TEntity entity);


    }
}
