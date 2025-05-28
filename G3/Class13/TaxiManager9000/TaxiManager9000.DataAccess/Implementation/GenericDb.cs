using TaxiManager9000.DataAccess.Abstraction.Interfaces;
using TaxiManager9000.Domain.Models;

namespace TaxiManager9000.DataAccess.Implementation
{
    public class GenericDb<T> : IGenericDb<T> where T : BaseEntity
    {
        private List<T> _db = new List<T>();
        private int _idCounter;

        public List<T> GetAll()
        {
            return _db;
        }

        public T GetById(int id)
        {
            T result = _db.SingleOrDefault(e => e.Id == id);
            return result;
        }

        public int Add(T entity)
        {
            entity.Id = ++_idCounter;
            _db.Add(entity);
            return entity.Id;
        }

        public bool Update(T entity)
        {
            try
            {
                T dbEntity = GetById(entity.Id);
                dbEntity = entity;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool RemoveById(int id)
        {
            try
            {
                T entity = GetById(id);
                _db.Remove(entity);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<T> FilterBy(Func<T, bool> filterCondition)
        {
            return _db.Where(filterCondition).ToList();
        }
    }
}
