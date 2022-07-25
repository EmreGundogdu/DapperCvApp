using Entities.Interfaces;

namespace DataAccess.Interfaces
{
    public interface IGenericRepository<T> where T : class, ITable, new()
    {
        List<T> GetAll();
        T GetById(int id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
