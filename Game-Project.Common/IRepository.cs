namespace Game_Project.Common;

public interface IRepository<TEntity, TId> where TEntity : IEntity<TId>
{
    Task<TEntity> GetByIdAsync(TId id);
    Task<IEnumerable<TEntity>> GetAllAsync();
    Task AddAsync(TEntity entity);
    Task UpdateAsync(TEntity entity);
    Task DeleteAsync(TId id);
}