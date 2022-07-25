using Dapper.Contrib.Extensions;
using DataAccess.Interfaces;
using Entities.Interfaces;
using System.Data;

namespace DataAccess.Concrete.Dapper
{
    public class DpGenericRepository<T> : IGenericRepository<T> where T : class, ITable, new()
    {
        private readonly IDbConnection _connection;

        public DpGenericRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public void Delete(T entity)
        {
            _connection.Delete(entity);
        }

        public List<T> GetAll()
        {
            return _connection.GetAll<T>().ToList();
        }

        public T GetById(int id)
        {
            return _connection.Get<T>(id);
        }

        public void Insert(T entity)
        {
            _connection.Insert(entity);
        }

        public void Update(T entity)
        {
            _connection.Update(entity);
        }
    }
}
