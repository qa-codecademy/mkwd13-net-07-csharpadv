using TaxiManager9000.Domain.Models;

namespace TaxiManager9000.DataAccess.Abstraction.Interfaces
{
    public interface IGenericDb<T> where T : BaseEntity
    {
        List<T> GetAll();
        T GetById(int id);
        int Add(T entity);
        bool Update(T entity);
        bool RemoveById(int id);
        List<T> FilterBy(Func<T, bool> filterCondition); 
    }
}
