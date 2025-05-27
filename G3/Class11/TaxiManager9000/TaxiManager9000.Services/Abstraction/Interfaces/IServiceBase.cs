using TaxiManager9000.Domain.Models;

namespace TaxiManager9000.Services.Abstraction.Interfaces
{
    public interface IServiceBase<T> where T : BaseEntity
    {
        List<T> GetAll();
        List<T> GetFiltered(Func<T, bool> whereClause);
        T GetById(int id);
        void Insert(T entity);
        void DeleteById(int id);
        bool Update(T entity);
        void Seed(List<T> entities);
    }
}
