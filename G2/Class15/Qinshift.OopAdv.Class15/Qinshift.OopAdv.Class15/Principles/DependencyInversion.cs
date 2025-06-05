using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qinshift.OopAdv.Class15.Principles
{
    //BAD EXAMPLE
    public class SQLDatabase
    {
        public void Save(string data)
        {
            Console.WriteLine("SAVED");
        }
    }
    public class DataProcessor
    {
        private SQLDatabase _db = new SQLDatabase();
        public void Proccess(string data)
        {
            _db.Save(data);
        }
    }

    //GOOD EXAMPLE
    public interface IDatabase
    {
        void Save(string data);
    }
    public class SQLDatabaseGood : IDatabase
    {
        public void Save(string data)
        {
            Console.WriteLine("SAVED");
        }
    }

    public class DataProcessorGood
    {
        private readonly IDatabase _dataBase;
        public DataProcessorGood(IDatabase database)
        {
                _dataBase = database;
        }
        public void Proccess(string data) 
        { 
            _dataBase.Save(data);
        }
    }
}
