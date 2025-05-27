namespace Qinshift.Disposable
{
    public class OurWriter : IDisposable
    {
        private StreamWriter _sw;

        private string _path;

        private bool _disposedValue;

        public OurWriter(string filePath)
        {
            _path = filePath;
            _sw = new StreamWriter(_path, true);
        }

        public void Write(string text)
        {
            _sw.WriteLine(text);
        }

        #region Dispose Implementation

        // We implement this private method that will remember when this class is disposed
        // That way, if the same class tries to get disposed again, all the Dispose() methods will not get called
        private void Dispose(bool disposing)
        {
            // This happens only when the class needs to be disposed the first time
            if (!_disposedValue)
            {
                if (disposing)
                {
                    _sw.Dispose();
                }
                _path = string.Empty;
                _disposedValue = true;
            }
        }

        // We can implement this method alone and add the disposing here
        public void Dispose()
        {
            Dispose(true);
        }
        #endregion
    }

    public class OurReader : IDisposable
    {
        private string _path;

        private bool _disposedValue;

        private StreamReader _sr;

        public OurReader(string path)
        {
            _path = path;
            _sr = new StreamReader(path);
        }

        public string Read()
        {
            return _sr.ReadToEnd();
        }

        #region Dispose Implementation

        // We implement this private method that will remember when this class is disposed
        // That way, if the same class tries to get disposed again, all the Dispose() methods will not get called
        private void Dispose(bool disposing)
        {
            // This happens only when the class needs to be disposed the first time
            if (!_disposedValue)
            {
                if (disposing)
                {
                    _sr.Dispose();
                }
                _path = string.Empty;
                _disposedValue = true;
            }
        }

        // We can implement this method alone and add the disposing here
        public void Dispose()
        {
            Dispose(true);
        }
        #endregion

    }
}
