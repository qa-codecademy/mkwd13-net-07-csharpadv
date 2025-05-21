using TaxiManager9000.Domain.Models;

namespace TaxiManager9000.DataAccess.Implementations
{
    public class LocalDb<T> : IDb<T> where T : BaseEntity
    {
        public int IdCount { get; set; }

        private List<T> _db;
        public LocalDb()
        {
            _db = new List<T>();
            IdCount = 1;
        }

        public List<T> GetAll()
        {
            return _db;
        }
        public T GetById(int id)
        {
            return _db.SingleOrDefault(x => x.Id == id);
        }
        public int Insert(T entity)
        {
            entity.Id = IdCount;
            _db.Add(entity);

            IdCount++;
            return entity.Id;
        }
        public void Update(T entity)
        {
            T itemFromLocalDb = _db.SingleOrDefault(x => x.Id == entity.Id);
            itemFromLocalDb = entity;
        }
        public void Delete(int id)
        {
            T itemFromLocalDb = _db.SingleOrDefault(x => x.Id == id);
            if(itemFromLocalDb != null) 
                _db.Remove(itemFromLocalDb);
        }
    }
}
