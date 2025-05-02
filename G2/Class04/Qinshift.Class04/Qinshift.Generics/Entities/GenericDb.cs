namespace Qinshift.Generics.Entities
{
    public class GenericDb<T> where T : BaseEntity
    {
        private List<T> _list;

        public GenericDb() 
        {
            _list = new List<T>();
        }

        public void PrintAll()
        {
            foreach (T item in _list)
            {
                Console.WriteLine(item.GetInfo());
            }
        }

        public void Insert(T item)
        {
            _list.Add(item);
        }

        public void InsertRange(List<T> list)
        {
            _list.AddRange(list);
        }

        public List<T> GetAll()
        {
            return _list;
        }

        public T GetById(int id)
        {
            return _list.Where(x => x.Id == id).FirstOrDefault();
        }

        public void RemoveById(int id)
        {
            T itemToDelete = GetById(id);
            if(itemToDelete != null) 
                _list.Remove(itemToDelete);
            Console.WriteLine("No such element to delete!");
        }

        
    }
}
