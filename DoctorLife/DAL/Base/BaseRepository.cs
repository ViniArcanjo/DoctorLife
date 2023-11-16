using DoctorLife.DAL.Interface;
using Microsoft.EntityFrameworkCore;

namespace DoctorLife.DAL.Base
{
    public abstract class BaseRepository<TEntity> : IDisposable, IBaseRepository<TEntity> where TEntity : class
    {
        private readonly Context _dbContext;

        public BaseRepository(Context dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<TEntity> GetAll()
        {
            return _dbContext.Set<TEntity>();
        }

        public IQueryable<TEntity> Get(Func<TEntity, bool> predicate)
        {
            return GetAll().Where(predicate).AsQueryable();
        }

        public TEntity Find(params object[] key)
        {
            return _dbContext.Set<TEntity>().Find(key);
        }

        public void Add(TEntity obj)
        {
            _dbContext.Set<TEntity>().Add(obj);
        }

        public void Update(TEntity obj)
        {
            _dbContext.Entry(obj).State = EntityState.Modified;
        }

        public void Delete(Func<TEntity, bool> predicate)
        {
            _dbContext.Set<TEntity>()
               .Where(predicate).ToList()
               .ForEach(del => _dbContext.Set<TEntity>().Remove(del));
        }

        public async Task SaveAll()
        {
            await _dbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _dbContext?.Dispose();
            }
        }
    }
}
