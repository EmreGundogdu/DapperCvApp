using Business.Interfaces;
using DataAccess.Interfaces;
using Entities.Interfaces;

namespace Business.Concrete
{
    public class GenericManager<T> : IGenericService<T> where T : class, ITable, new()
    {
        private readonly IGenericRepository<T> _genericRepository;

        public GenericManager(IGenericRepository<T> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public void Delete(T entity)
        {
            _genericRepository.Delete(entity);
        }

        public List<T> GetAll()
        {
            return _genericRepository.GetAll();
        }

        public T GetById(int id)
        {
            return _genericRepository.GetById(id);
        }

        public void Insert(T entity)
        {
            _genericRepository.Insert(entity);
        }

        public void Update(T entity)
        {
            _genericRepository.Update(entity);
        }
    }
}
