using Generics.Domain.Models;
using System.Diagnostics.Contracts;

namespace Generics.Domain
{
    //GenericDb can work with any type, but that type has to be either BaseEntity 
    //or it has to inherit from BaseEntity
    public class GenericDb<T> where T : BaseEntity
    {
        private List<T> items;

        public GenericDb()
        {
            items = new List<T>();

        }

        //Read Operations
        public void PrintAll()
        {
            foreach(T item in items)
            {
                //we can call GetInfo because T MUST inherit from BaseEntity, which means that the item has the method GetInfo
                Console.WriteLine(item.GetInfo()); 
            }
        }

        //Read
        public T GetById(int id)
        {
            //Select *
            //FROM Product/Order
            //WHERE Id = id

            //because T inherits from BaseEntity, T will always have a property Id
            return items.FirstOrDefault(x => x.Id == id);
        }

        //Create
        public void Add(T item)
        {
            items.Add(item);
            Console.WriteLine("The item was added");
        }

        public void RemoveById(int id)
        {
            //T itemToRemove = GetById(id);
            T itemToRemove = items.FirstOrDefault(x => x.Id == id);
            if(itemToRemove == null)
            {
                Console.WriteLine($"There is no member with id {id}");
                return;
            }
            items.Remove(itemToRemove); //we pass the whole item object that we want to remove from the db
            Console.WriteLine("The item was removed");
        }
    }
}
