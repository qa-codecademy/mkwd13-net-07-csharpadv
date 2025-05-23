namespace Qinshift.SerializeDeserialize.Entities
{
    public class ReaderWriter
    {
        public string ReadFile(string path)
        {
            string result = string.Empty;

            using (StreamReader sr = new(path, true))
            {
                result = sr.ReadToEnd();
            }

            return result;
        }

        public void WriteInFile(string path, string data)
        {
            using (StreamWriter sw = new(path))
            {
                sw.WriteLine(data);
            }
        }
    }
}
