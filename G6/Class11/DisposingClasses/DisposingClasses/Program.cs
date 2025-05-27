using DisposingClasses;

string appPath = @"..\..\..\Example";
string filePath = appPath + @"\example.txt";

#region ManualDispose
void AppendTextToFile(string text, string filePath)
{
    StreamWriter writer = new StreamWriter(filePath, true);
    writer.WriteLine(text);
    //StreamWriter implements IDisposable interface. That means that it implements the Dispose method
    //This method has to be called so that the writer is destroyed and the connection to the file is closed
    //Here we need to call this method explicitly, since we don't have an using block

    writer.Dispose(); //we can make sure that this is always executed, even if an error happens if we wrap the code in try-catch-finally and put the Dispose call in finally
}

void ReadTextFromFile(string filePath)
{
    StreamReader reader = new StreamReader(filePath);
    string text = reader.ReadToEnd();
    Console.WriteLine(text);

    //StreamReader implements IDisposable interface. That means that it implements the Dispose method
    //This method has to be called so that the writer is destroyed and the connection to the file is closed
    //Here we need to call this method explicitly, since we don't have an using block
    reader.Dispose();
}

if (!Directory.Exists(appPath))
{
    Directory.CreateDirectory(appPath);
}
try
{
    AppendTextToFile("Hello world", filePath);
    ReadTextFromFile(filePath);
}catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
#endregion

#region Disposing with using

void AppendTextInFileWithUsing(string text, string filePath)
{
    using(StreamWriter streamWriter = new StreamWriter(filePath, true))
    {
        streamWriter.WriteLine(text);
    } //here (when using block ends) streamWriter.Dispose() is automatically called, we don't have to call it ourselves
}

void ReadFromFileWithUsing(string filePath)
{
    using(StreamReader streamReader = new StreamReader(filePath))
    {
        string text = streamReader.ReadToEnd();
        Console.WriteLine(text);
    }//here (when the using block ends) streamReader.Dispose() is automatically called
}
#endregion

#region Dispose with Custom class
void AppendTextToFileWithCustomWriter(string text, string filePath)
{
    using(CustomWriter writer = new CustomWriter(filePath))
    {
        writer.Write(text);
    }//here the Dispose method from our CustomWriter with our impl will be called
}

AppendTextToFileWithCustomWriter("Hello from custom writer", filePath);
#endregion