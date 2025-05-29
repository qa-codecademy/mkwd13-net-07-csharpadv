namespace SerializationAndDeserialization
{
    public class CustomReaderWriter
    {
        public string ReadFromFile(string filePath)
        {
            //validation that the file exists
            //StreamReader does not create the file of the file does not exist, it expects to read something from a file, so the file should already exist
            //(StreamWriter is the one that creates a file because it can write to a new empty file as well)
            if (!File.Exists(filePath))
            {
                throw new Exception($"File on path {filePath} does not exist");
            }

            string result = string.Empty; //''
            using (StreamReader sr = new StreamReader(filePath))
            {
                result = sr.ReadToEnd(); //with ReadToEnd we get the whole content from the file
            }

            return result;
        }

        public void WriteToFile(string text, string filePath)
        {
            //here, the streamWriter creates a file if the file does not already exist
            using(StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine(text);
            }
        }
    }
}
