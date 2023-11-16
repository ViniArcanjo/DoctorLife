namespace DoctorLife.DAL.Interface
{
    public interface IEntityBaseRepository<T>
    {
        public Task<List<T>> GetAll();
        public Task<T> GetById(long id);
        public Task<T> Create(T entity);
        public Task<T> Update(T entity);
    }
}
