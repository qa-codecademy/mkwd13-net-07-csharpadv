namespace Generics.Entities.Interfaces
{
    public interface IGenericDb<T>
    {
        List<T> GetAll();
        void PrintAll();
        void Insert(T item);
        T GetById(int id);
        void RemoveById(int id);
    }
}
