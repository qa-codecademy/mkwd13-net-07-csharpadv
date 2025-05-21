using TryBeingFit.Domain.Models;

namespace TryBeingFit.Domain.Database
{
    public class Database<T> : IDatabase<T> where T : BaseEntity
    {
        //we mark the list as private, because we don't want anyone from outside to be able to 
        //directlly access and modify the items. We will want to use the methods to manipulate with the list
        private List<T> items { get; set; }
        public int LastUsedId { get; set; }

        public Database()
        {
            items = new List<T>();
            LastUsedId = 1; //we don't have the db identity, so we will need to manually increment the id
        }
        public List<T> GetAll()
        {
            return items; //here we need to return the whole list, all the items => SELECT * FROM T
        }

        public T GetById(int id)
        {
            T item = items.FirstOrDefault(x => x.Id == id);
            //validation
            if(item == null)
            {
                throw new NullReferenceException($"Entity with id {id} was not found in the db");
            }
            return item;
        }

        public int Insert(T item)
        {
            //item.Id = LastUsedId             
            //LastUsedId = LastUsedId + 1
            
            //item.Id = LastUsedId++ => 1. item.Id = LastUsedId 2. LastUsedId = LastUsedId + 1
            //item.Id = ++LastUsedId => 1. LastUsedId = LastUsedId + 1  1. item.Id = LastUsedId
            item.Id = LastUsedId;
            LastUsedId++;   //we set the id property of the item and then we increment the value of the property Id
            items.Add(item);
            return item.Id;
        }

        public void RemoveById(int id)
        {
            //T item = items.FirstOrDefault(x => x.Id == id);
            ////validation
            //if (item == null)
            //{
            //    throw new NullReferenceException($"Entity with id {id} was not found in the db");
            //}
            T item = GetById(id);
            items.Remove(item);
           
        }

        public void Update(T entity)
        {
            //first we search if the item that we want to update exists in our db (our items list)
            T item = GetById(entity.Id);

            //we have to find the index of the item that we want to replace and switch its value
            int indexOfElement = items.IndexOf(item);
            items[indexOfElement] = entity; //on the place (index) of the existing item that we want to update, we put the new updated version of the entity 

        }
    }
}
