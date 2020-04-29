using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Dime
{
    /// <summary>
    /// Defines the capabilities of a read-only service
    /// </summary>
    /// <typeparam name="TEntity">Represents the entity of the underlying data storage medium</typeparam>
    public interface IQueryService<TEntity> : IService
    {
        /// <summary>
        /// Gets all the records for this type.
        /// </summary>
        /// <typeparam name="TModel">The model that is used in the service layer to manipulate the <typeparam name="TEntity"> domain model</typeparam></typeparam>
        /// <returns>An instance of <see cref="Task"/> that holds a collection of <see cref="TModel"/> model instances</returns>
        Task<IEnumerable<TModel>> GetAllAsync<TModel>();

        /// <summary>
        /// Gets all the records for this type that pass the filter expression.
        /// </summary>
        /// <typeparam name="TModel">The model that is used in the service layer to manipulate the <typeparam name="TEntity"> domain model</typeparam></typeparam>
        /// <param name="filter">The expression to execute in the data store</param>
        /// <returns>An instance of <see cref="Task"/> that holds a collection of <see cref="TModel"/> model instances</returns>
        Task<IEnumerable<TModel>> GetAllAsync<TModel>(Expression<Func<TEntity, bool>> filter);

        /// <summary>
        /// Gets all the records for this type that pass the filter expression.
        /// </summary>
        /// <typeparam name="TModel">The model that is used in the service layer to manipulate the <typeparam name="TEntity"> domain model</typeparam></typeparam>
        /// <param name="filter">The expression to execute in the data store</param>
        /// <param name="selector">The selector to transform items from type <see cref="TEntity"/> to <see cref="TModel"/></param>
        /// <returns>An instance of <see cref="Task"/> that holds a collection of <see cref="TModel"/> model instances</returns>
        Task<IEnumerable<TModel>> GetAllAsync<TModel>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TModel>> selector);

        /// <summary>
        /// Gets one record that passes the filter expression
        /// </summary>
        /// <typeparam name="TModel">The model that is used in the service layer to manipulate the <typeparam name="TEntity"> domain model</typeparam></typeparam>
        /// <param name="filter">The expression to execute in the data store</param>
        /// <returns>An instance of <see cref="Task"/> that holds an instance of the <see cref="TModel"/> class</returns>
        Task<TModel> GetOneAsync<TModel>(Expression<Func<TEntity, bool>> filter);
    }
}