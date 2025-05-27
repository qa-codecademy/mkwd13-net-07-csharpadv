namespace Logger
{
    public class LoggerService
    {
        private string folderPath;
        private string filePath;

        public LoggerService()
        {
            folderPath = @"..\..\..\logs";
            filePath = folderPath + @"\logs.txt";

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
        }

        public void Log(string message, bool isError)
        {
            using(StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine($"Time: {DateTime.Now}");
                if(isError)
                {
                    sw.WriteLine($"ERROR: {message}");
                }
                else
                {
                    sw.WriteLine($"INFO: {message}");
                }

                sw.WriteLine("=======================================");
            }
        }
    }
}
