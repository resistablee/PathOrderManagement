using Microsoft.EntityFrameworkCore;
using PathOrderManagement.DataAccess.Repositories.Abstract;
using PathOrderManagement.Entity.DbPathOrderManagement.Base;
using System.Linq.Expressions;

namespace PathOrderManagement.DataAccess.Repositories.Concrete
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : SoftDeleteEntity
    {
        private readonly DataContext _context;
        private readonly DbSet<TEntity> _entity;

        public GenericRepository(DataContext context)
        {
            _context = context;
            _entity = _context.Set<TEntity>();
        }

        #region Select operations
        public IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
            => _entity.Where(predicate);

        public TEntity FindOne(Expression<Func<TEntity, bool>> predicate)
            => _entity.FirstOrDefault(predicate);

        public async Task<TEntity> FindOneAsync(Expression<Func<TEntity, bool>> predicate)
            => await _entity.FirstOrDefaultAsync(predicate);

        public async Task<TEntity> FindOneWithAsNoTrackingAsync(Expression<Func<TEntity, bool>> predicate)
            => await _entity.AsNoTracking().FirstOrDefaultAsync(predicate);

        public IEnumerable<TEntity> FindAll(Expression<Func<TEntity, bool>> predicate)
            => _entity.Where(predicate).ToList();

        public async Task<List<TEntity>> FindAllAsync(Expression<Func<TEntity, bool>> predicate)
            => await _entity.Where(predicate).ToListAsync();

        public async Task<List<TEntity>> FindAllWithAsNoTrackingAsync(Expression<Func<TEntity, bool>> predicate)
            => await _entity.AsNoTracking().Where(predicate).ToListAsync();

        //Only select operation
        public async Task<List<TEntity>> GetAllAsync()
            => await _entity.ToListAsync();

        public async Task<List<TEntity>> GetAllWithAsNoTrackingAsync()
            => await _entity.AsNoTracking().ToListAsync();

        public async Task<List<TEntity>> GetAllWithAsNoTrackingAndPagingAsync(Expression<Func<TEntity, bool>> predicate, int skip, int take)
            => await _entity.AsNoTracking().Where(predicate).Skip(skip).Take(take).ToListAsync();
        #endregion


        #region Insert operations
        public async Task<TEntity> InsertAsync(TEntity entity)
        {
            await _entity.AddAsync(entity);

            await _context.SaveChangesAsync();
            _context.Entry(entity).State = EntityState.Detached;

            return entity;
        }

        public async Task<List<TEntity>> InsertManyAsync(List<TEntity> entityList)
        {
            entityList = await AnyManyAsync(entityList);

            _entity.AddRangeAsync(entityList);
            await _context.SaveChangesAsync();

            foreach (var entity in entityList)
            {
                _context.Entry(entity).State = EntityState.Detached;
            }

            return entityList;
        }
        #endregion


        #region Delete operations
        public async Task DeleteAsync(TEntity entity)
        {
            var data = await FindOneAsync(x => x == entity);

            data.IsDeleted = true;
            data.DeletedOn = DateTime.UtcNow;
            //data.DeletedBy = //TODO: Kullanıcı adı eklenecek.

            await UpdateAsync(data);
        }
        #endregion


        #region Update operations
        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            _context.Set<TEntity>().Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            _context.Entry(entity).State = EntityState.Detached;

            return entity;
        }
        #endregion


        #region Other operations

        //Any
        public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate)
            => await _entity.AnyAsync(predicate);

        public async Task<bool> AnyAsync(TEntity entity)
            => await _entity.AnyAsync(x => x == entity);

        //Remove existing data in database from list
        public async Task<List<TEntity>> AnyManyAsync(List<TEntity> entityList)
        {
            foreach (var entity in entityList)
            {
                if (await _entity.AnyAsync(x => x == entity))
                    entityList.Remove(entity);
            }

            return entityList;
        }

        //Count
        public Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate)
            => _entity.CountAsync(predicate);
        #endregion
    }
}
