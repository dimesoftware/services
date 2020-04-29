using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dime
{
    /// <summary>
    /// Defines the capabilities of a write-only service
    /// </summary>
    /// <typeparam name="TEntity">Represents the entity of the underlying data storage medium</typeparam>
    public interface ICommandService<TEntity> : IService
    {
        /// <summary>
        /// Creates an item
        /// </summary>
        /// <typeparam name="TModel">The model that is used in the service layer to manipulate the <typeparam name="TEntity"> domain model</typeparam></typeparam>
        /// <param name="item">The item to create</param>
        /// <returns>An instance of <see cref="Task"/> that holds an instance of the <see cref="TModel"/> class</returns>
        Task<TModel> CreateAsync<TModel>(TModel item);

        /// <summary>
        /// Creates a collection of items
        /// </summary>
        /// <typeparam name="TModel">The model that is used in the service layer to manipulate the <typeparam name="TEntity"> domain model</typeparam></typeparam>
        /// <param name="items">The items to create</param>
        /// <returns>An instance of <see cref="Task"/> that holds a collection of created <see cref="TModel"/> instances</returns>
        Task<IEnumerable<TModel>> CreateAsync<TModel>(IEnumerable<TModel> items);

        /// <summary>
        /// Updates an item
        /// </summary>
        /// <typeparam name="TModel">The model that is used in the service layer to manipulate the <typeparam name="TEntity"> domain model</typeparam></typeparam>
        /// <param name="item">The item to update</param>
        /// <returns>An instance of <see cref="Task"/> that holds an instance of the <see cref="TModel"/> class</returns>
        Task<TEntity> UpdateAsync<TModel>(TModel item);

        /// <summary>
        ///  Updates a collection of items
        /// </summary>
        /// <typeparam name="TModel">The model that is used in the service layer to manipulate the <typeparam name="TEntity"> domain model</typeparam></typeparam>
        /// <param name="items">The items to update</param>
        /// <returns>An instance of <see cref="Task"/> that holds a collection of updated <see cref="TModel"/> instances</returns>
        Task<IEnumerable<TModel>> UpdateAsync<TModel>(IEnumerable<TModel> items);

        /// <summary>
        /// Removes an item
        /// </summary>
        /// <typeparam name="TModel">The model that is used in the service layer to manipulate the <typeparam name="TEntity"> domain model</typeparam></typeparam>
        /// <param name="item">The item to remove</param>
        /// <returns>An instance of <see cref="Task"/></returns>
        Task DeleteAsync<TModel>(TModel item);

        /// <summary>
        /// Removes a collection of items
        /// </summary>
        /// <typeparam name="TModel">The model that is used in the service layer to manipulate the <typeparam name="TEntity"> domain model</typeparam></typeparam>
        /// <param name="items">The items to remove</param>
        /// <returns>An instance of <see cref="Task"/></returns>
        Task DeleteAsync<TModel>(IEnumerable<TModel> items);
    }
}