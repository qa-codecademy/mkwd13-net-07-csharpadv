using TaxiManager9000.Domain.Models;

namespace TaxiManager9000.DataAccess
{
    public interface IDb<T> where T : BaseEntity
    {
        // CRUD Methods
        List<T> GetAll();
        T GetById(int id);
        int Insert(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
