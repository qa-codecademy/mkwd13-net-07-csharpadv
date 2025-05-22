namespace Qinshift.Disposable.OurStreamClasses
{
    public class OurWriter : IDisposable
    {
        private string _path;

        private StreamWriter _streamWriter;

        private bool _disposedValue = false;

        public OurWriter(string filePath)
        {
            _path = filePath;
            _streamWriter = new StreamWriter(_path, true);
        }

        public void Write(string text)
        {
            _streamWriter.WriteLine(text);
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
                    _streamWriter.Dispose();
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
