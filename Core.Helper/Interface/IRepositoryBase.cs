namespace Core.Helper.Interface;
/// <summary>
///     simple base action for all  crud
/// </summary>
/// <typeparam name="TEntity"></typeparam>
/// <typeparam name="TKey">type key for entity</typeparam>
public interface IRepositoryBase<in TKey,TEntity> where TEntity : class 
{
    /// <summary>
    ///     Insert entity 
    /// </summary>
    /// <param name="entity">entity make insert</param>
    /// <returns>
    ///     Return entity has insert success otherwise throw exception
    /// </returns>
    Task<TEntity> InsertAsync(TEntity entity);
    /// <summary>
    ///     update entity
    /// </summary>
    /// <param name="entity">entity make update</param>
    /// <returns>
    ///     Return entity has update success otherwise throw exception
    /// </returns>
    Task<TEntity> UpdateAsync(TEntity entity);
    /// <summary>
    ///     delete entity
    /// </summary>
    /// <param name="entity">entity make deleted</param>
    /// <returns>
    ///     keep flow if delete success otherwise throw exception
    /// </returns>
    Task DeleteAsync(TEntity entity);
    /// <summary>
    ///     Get entity has id
    /// </summary>
    /// <param name="id">id for entity</param>
    /// <returns>
    ///     Return entity if match id otherwise return null 
    /// </returns>
    Task<TEntity?> GetByIdAsync(TKey id);
    /// <summary>
    ///     Get all entity
    /// </summary>
    /// <param name="conditions">condition for filter data in table</param>
    /// <param name="sort">sort properties if you want make sort</param>
    /// <returns>
    ///     Return all entity has match condition otherwise throw exception
    /// </returns>
    Task<IEnumerable<TEntity>> GetListEntityAsync(object conditions, object sort);
}