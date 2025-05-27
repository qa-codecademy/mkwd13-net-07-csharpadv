namespace DisposingClasses
{
    public class CustomWriter : IDisposable
    {
        private string _filePath;
        private StreamWriter _writer; //we are simulating the use of our own resource (our own writer)
        private bool _isDisposed = false;
        public CustomWriter(string filepath)
        {
            _filePath = filepath;
            _writer = new StreamWriter(filepath);
        }

        public void Write(string text)
        {
            try
            {
                if(text.ToLower() == "stop")
                {
                    throw new Exception("We should not write to the file..");
                }
                _writer.WriteLine(text); //in our custom writer we would use another way to write
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Dispose()
        {
            if(! _isDisposed)
            {
                _writer.Dispose();//here we call the Dispose from StreamWriter (if we have our own way of writing and using streams, here we would have a different impl for Dispose)
                _isDisposed = true; //we use a flag to make sure we don't call Dispose multiple time for the same instance of CustomWriter
            }
        }
    }
}
