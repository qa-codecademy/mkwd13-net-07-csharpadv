using Generics.Domain.Models;
using Generics.Entities.Interfaces;

namespace Generics.Entities.Data
{
    // "where T : BaseEntity" ===> only classes derived from BaseEntity are allowed to use GenericDb<T>
    public class GenericDb<T> : IGenericDb<T> where T : BaseEntity
    {
        private List<T> _db;

        public GenericDb()
        {
            _db = new List<T>();
        }

        public List<T> GetAll()
        {
            return _db;
        }

        public T GetById(int id)
        {
            return _db.SingleOrDefault(e => e.Id == id);
        }

        public void PrintAll()
        {
            foreach (T item in _db)
            {
                Console.WriteLine(item.GetInfo());
            }
        }

        public void Insert(T item)
        {
            _db.Add(item);
            Console.WriteLine($"Item was added in the {typeof(T).Name} Database!");
        }

        public void RemoveById(int id)
        {
            T itemToRemove = GetById(id);
            //ArgumentNullException.ThrowIfNull(itemToRemove);
            if (itemToRemove is null)
            {
                throw new ArgumentNullException("No item found with id " + id);
            }
            _db.Remove(itemToRemove);
        }
    }
}
