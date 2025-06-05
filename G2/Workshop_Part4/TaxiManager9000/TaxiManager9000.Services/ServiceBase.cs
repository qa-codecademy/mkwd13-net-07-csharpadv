using System.Data;
using TaxiManager9000.DataAccess;
using TaxiManager9000.DataAccess.Implementations;
using TaxiManager9000.Domain.Models;
using TaxiManager9000.Services.Interfaces;

namespace TaxiManager9000.Services
{
    public class ServiceBase<T> : IServiceBase<T> where T : BaseEntity
    {
        protected IDb<T> _dbInstance;

        public ServiceBase()
        {
           _dbInstance = new LocalDb<T>();
        }

        public List<T> GetAll()
        {
           return _dbInstance.GetAll();
        }
        public List<T> GetAll(Func<T, bool> whereCondition)
        {
            return _dbInstance.GetAll().Where(whereCondition).ToList();
        }
        public T GetSingle(int id)
        {
            return _dbInstance.GetById(id);
        }
        public void Add(T item)
        {
            _dbInstance.Insert(item);
        }
        public void Remove(int id)
        {
            _dbInstance.Delete(id);
        }
        public void Seed(List<T> items)
        {
            if (_dbInstance.GetAll().Count > 0)
                return;
            items.ForEach(item => _dbInstance.Insert(item));
        }

    }
}
