using TaxiManager9000.DataAccess.Abstraction.Interfaces;
using TaxiManager9000.DataAccess.Implementation;
using TaxiManager9000.Domain.Models;
using TaxiManager9000.Services.Abstraction.Interfaces;

namespace TaxiManager9000.Services.Abstraction
{
    public abstract class ServiceBase<T> : IServiceBase<T> where T : BaseEntity
    {
        private readonly IGenericDb<T> _db;

        protected ServiceBase()
        {
            _db = new GenericDb<T>();
        }

        public List<T> GetAll()
        {
            return _db.GetAll();
        }

        public T GetById(int id)
        {
            return _db.GetById(id);
        }

        public List<T> GetFiltered(Func<T, bool> whereClause)
        {
            return _db.FilterBy(whereClause);
        }

        public void Insert(T entity)
        {
            _db.Add(entity);
        }

        public bool Update(T entity)
        {
            return _db.Update(entity);
        }

        public void DeleteById(int id)
        {
            _db.RemoveById(id);
        }

        public void Seed(List<T> entities)
        {
            entities.ForEach(e => _db.Add(e));
        }
  
    }
}
