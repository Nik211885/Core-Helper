namespace Core.Helper.Interface;
/// <summary>
///     simple base action for all  crud
/// </summary>
/// <typeparam name="TEntity"></typeparam>
/// <typeparam name="TKey">type key for entity</typeparam>
public interface IRepositoryBase<in TKey,TEntity> where TEntity : class 
{
    Task<TEntity> InsertAsync(TEntity entity);
    Task<TEntity> UpdateAsync(TEntity entity);
    Task DeleteAsync(TEntity entity);
    Task<TEntity?> GetByIdAsync(TKey id);
}