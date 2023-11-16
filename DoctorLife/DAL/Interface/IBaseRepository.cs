namespace DoctorLife.DAL.Interface
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        public IQueryable<TEntity> GetAll();
        public IQueryable<TEntity> Get(Func<TEntity, bool> predicate);
        public TEntity Find(params object[] key);
        public void Update(TEntity obj);
        public Task SaveAll();
        public void Add(TEntity obj);
        public void Delete(Func<TEntity, bool> predicate);
    }
}
