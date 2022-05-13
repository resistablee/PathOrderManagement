using System.Linq.Expressions;

namespace PathOrderManagement.DataAccess.Repositories.Abstract
{
    public interface IGenericRepository<TEntity>
    {
        //Select Operations
        IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        TEntity FindOne(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity> FindOneAsync(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity> FindOneWithAsNoTrackingAsync(Expression<Func<TEntity, bool>> predicate);
        IEnumerable<TEntity> FindAll(Expression<Func<TEntity, bool>> predicate);
        Task<List<TEntity>> FindAllAsync(Expression<Func<TEntity, bool>> predicate);
        Task<List<TEntity>> FindAllWithAsNoTrackingAsync(Expression<Func<TEntity, bool>> predicate);
        Task<List<TEntity>> GetAllAsync();
        Task<List<TEntity>> GetAllWithAsNoTrackingAsync();
        Task<List<TEntity>> GetAllWithAsNoTrackingAndPagingAsync(Expression<Func<TEntity, bool>> predicate, int skip, int take);


        //Delete Operations
        Task DeleteAsync(TEntity entity);


        //Insert Operations
        Task<TEntity> InsertAsync(TEntity entity);
        Task<List<TEntity>> InsertManyAsync(List<TEntity> entityList);


        //Update Operations
        Task<TEntity> UpdateAsync(TEntity entity);


        //Other Operations
        Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate);
        Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate);
    }
}
