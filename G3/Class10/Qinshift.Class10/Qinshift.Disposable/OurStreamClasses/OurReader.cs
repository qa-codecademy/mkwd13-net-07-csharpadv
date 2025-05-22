namespace Qinshift.Disposable.OurStreamClasses
{
    public class OurReader : IDisposable
    {
        private string _path;

        private StreamReader _streamReader;

        private bool _disposedValue = false;

        public OurReader(string filePath)
        {
            _path = filePath;
            _streamReader = new StreamReader(_path);
        }

        public string Read()
        {
            return _streamReader.ReadToEnd();
        }

        private void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    _streamReader.Dispose();
                }

                _path = string.Empty;
                _disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }
    }
}
