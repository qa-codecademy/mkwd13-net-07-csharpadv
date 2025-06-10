using Newtonsoft.Json;
using System.Data.Common;
using TryBeingFit.Domain.Models;

namespace TryBeingFit.Domain.Database
{
    public class FileDatabase<T> : IDatabase<T> where T : BaseEntity
    {
        private string _folderPath;
        private string _filePath;
        private int _id;

        public FileDatabase()
        {
            _folderPath = @"..\..\..\FileDatabase";
            _filePath = _folderPath + $@"\{typeof(T).Name}s.json";

            //validation if folder and file exist
            if (!Directory.Exists(_folderPath))
            {
                Directory.CreateDirectory(_folderPath);
            }

            if(!File.Exists(_filePath))
            {
                File.Create(_filePath).Close();
                WriteEntitiesToFile(new List<T>()); //this way our file will never be empty (it will never have the value null)
            }

            if (File.Exists(_filePath))
            {
                List<T> entities = ReadEntitiesFromFile(); //read the entities that already exist in our file db
                if(entities != null && entities.Count >0) {
                    _id = entities.Last().Id;
                }
                else
                {
                    _id = 0;
                }
            }
            else
            {
                _id = 0;
            }
        }
        public List<T> GetAll()
        {
            return ReadEntitiesFromFile();
        }

        public T GetById(int id)
        {
            //get all
            List<T> entities = GetAll();
            return entities.FirstOrDefault(x => x.Id == id);
        }

        public int Insert(T entity)
        {
            //validation
            if (entity == null)
            {
                throw new Exception("Entity cannot be null");
            }

            entity.Id = ++_id; //first increment the id, the assign it to entity.Id

            List<T> dbEntities = ReadEntitiesFromFile();
            if(dbEntities == null)
            {
                dbEntities = new List<T>(); //in case there was a mistake and the content of our file became null
            }
            dbEntities.Add(entity);
            //write
            WriteEntitiesToFile(dbEntities); //all the entities - the old ones plus the newly added entity
            return entity.Id;
        }

        public void RemoveById(int id)
        {
            T entityForRemove = GetById(id);
            List<T> dbEntities = ReadEntitiesFromFile();
            dbEntities.Remove(entityForRemove); //remove the entity from the list of entities
            WriteEntitiesToFile(dbEntities); //write the updated list (without the removed entity) in the file
        }

        public void Update(T entity)
        {
            //validation
            if (entity == null)
            {
                throw new Exception("Entity cannot be null");
            }

            List<T> values = ReadEntitiesFromFile(); //we need to read all entities from our db 
            T entityForUpdate = GetById(entity.Id);

            int index = values.IndexOf(entityForUpdate); //find the index of the entity that needs to be updated
            values[index] = entity; //update the entity acording to the index (insert the updated version of the entity in the place of the old version of that entity)
            WriteEntitiesToFile(values); //write the new version of the list (updated list) in the file
        }

        private List<T> ReadEntitiesFromFile()
        {
            string content = ""; //string.Empty;
            using(StreamReader reader = new StreamReader(_filePath))
            {
                content = reader.ReadToEnd(); //read the whole content from the file -> json
            }

            //deserialization - from json to object
            List<T> result = JsonConvert.DeserializeObject<List<T>>(content);
            return result;
        }

        private void WriteEntitiesToFile(List<T> entities)
        {
            using(StreamWriter writer = new StreamWriter(_filePath))
            {
                //serialize 
                string newContent = JsonConvert.SerializeObject(entities);

                //write
                writer.WriteLine(newContent);
            }
        }
    }
}
