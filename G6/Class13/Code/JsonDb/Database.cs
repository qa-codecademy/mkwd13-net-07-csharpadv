using JsonDb.Models;
using Newtonsoft.Json;

namespace JsonDb
{
    public class Database<T> where T : BaseEntity
    {
        // private List<T> _items; //we dont want to keep data in memory, we want to save it to a json file depanding on what we are saving
        private string _folderPath;
        private string _filePath;
        private int _id;
        public Database()
        {
            _folderPath = @"..\..\..\Database";
            //..\..\..\Database\Students.json
            //..\..\..\Database\Subjects.json
            _filePath = _folderPath + $@"\{typeof(T).Name}s.json"; //with typeOf we get the type of T, and with Name we get the name of the type


            //always check if directory and file exist, if not - create them
            if (!Directory.Exists(_folderPath))
            {
                Directory.CreateDirectory(_folderPath);
            }

            if(!File.Exists(_filePath))
            {
                //we will try to read from the file
                //the StreamReader does not create the file if it does not exist (only the StreamWriter does that)
                File.Create(_filePath).Close();
            }

            List<T> data = ReadFromFile(); //read from json file 
            if(data == null)
            {
                _id = 0; //invalid json or file was empty
            }
            else
            {
                if(data.Count > 0)
                {
                    _id = data.Last().Id;
                }
                else
                {
                    _id = 0;
                }
            }

        }

        private List<T> ReadFromFile()
        {
            try
            {
                using(StreamReader sr = new StreamReader(_filePath))
                {
                    string data = sr.ReadToEnd();
                    return JsonConvert.DeserializeObject<List<T>>(data);
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null; //our catch only writes in the console, and our method expects a return, so we return null as default
            }
        }

        private void WriteToFile(List<T> data) //List<Student>, List<Subject>
        {
            try
            {
                //because we want to write to json file, we need to serialize the data to json first
                string jsonData = JsonConvert.SerializeObject(data);
                using(StreamWriter sw = new StreamWriter(_filePath))
                {
                    sw.WriteLine(jsonData);
                }

            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public List<T> GetAll()
        {
            List<T> data = ReadFromFile(); //read from file will read from the json file and deserialize the json into a List<T>
            return data;
        }

        public T GetById(int id)
        {
            //get all items
            List<T> data = GetAll();
            if(data != null) //read from file can return null if the file is empty
            {
                return data.FirstOrDefault(x => x.Id == id);
            }
            else
            {
                return null;
            }
        }

        public void Insert(T item)
        {
            List<T> data = ReadFromFile(); //GetAll()
            if(data == null)
            {
                data = new List<T>(); //if the file is empty, the value of data will be null, so we need to init it to an empty list
            }
            _id++;
            item.Id = _id;
            data.Add(item);
            WriteToFile(data); //WriteToFile serialize our data into json and writes it to the file
        }
    
    }
}
