using Qinshift.Disposable.OurStreamClasses;
using Qinshift.Helpers;

ExtendedConsole.PrintInColor("\n================== DISPOSING ==================\n\n", ConsoleColor.Cyan);
// => process of releasing unmanaged resources such as file handles, database connections, and network connections
// => it's important to dispose of these resources properly to avoid memory leaks and ensure the efficient use of resources

const string AppPath = @"..\..\..\Text";
const string FileName = @"text.txt";
const string FilePath = $@"{AppPath}\{FileName}";

if (!Directory.Exists(AppPath))
{
    Directory.CreateDirectory(AppPath);
}

if (!File.Exists(FilePath))
{
    File.Create(FilePath).Close();
}


#region Manual Dispose Methods

void AppendTextInFile(string text, string path)
{
    StreamWriter sw = new StreamWriter(path, true);
    sw.WriteLine(text);
    sw.Dispose();
}

void ReadTextFromFile(string path)
{
    StreamReader sr = new StreamReader(path);
    Console.WriteLine(sr.ReadToEnd());
    sr.Dispose();
}

void ManualDisposeExample()
{
    try
    {
        ExtendedConsole.PrintInColor("Enter text pt1:");
        string text1 = Console.ReadLine();
        AppendTextInFile(text1, FilePath);

        ExtendedConsole.PrintInColor("Enter text pt2:");
        string text2 = Console.ReadLine();
        AppendTextInFile(text2, FilePath);

        ExtendedConsole.PrintInColor("Enter text pt3:");
        string text3 = Console.ReadLine();
        AppendTextInFile(text3, FilePath);
    }
    catch (Exception ex)
    {
        ExtendedConsole.PrintError("ERROR WRITING IN FILE: " + ex.Message);
    }

    try
    {
        ExtendedConsole.PrintInColor("--------- Read ---------\n");
        ReadTextFromFile(FilePath);
        ReadTextFromFile(FilePath);
    }
    catch (Exception ex)
    {
        ExtendedConsole.PrintError("ERROR READING FILE: " + ex.Message);
    }
}
#endregion


#region Dispose with Using Block
void AppendTextInFileSafe(string text, string path)
{
    using (StreamWriter sw = new StreamWriter(path, true))
    {
        sw.WriteLine(text);
    }
}

void ReadTextFromFileSafe(string path)
{
    using StreamReader sr = new StreamReader(path);
    Console.WriteLine(sr.ReadToEnd());
}

void UsingBlockDisposeExample()
{
    try
    {
        ExtendedConsole.PrintInColor("Enter text pt1:");
        string text1 = Console.ReadLine();
        AppendTextInFileSafe(text1, FilePath);

        ExtendedConsole.PrintInColor("Enter text pt2:");
        string text2 = Console.ReadLine();
        AppendTextInFileSafe(text2, FilePath);

        ExtendedConsole.PrintInColor("Enter text pt3:");
        string text3 = Console.ReadLine();
        AppendTextInFileSafe(text3, FilePath);
    }
    catch (Exception ex)
    {
        ExtendedConsole.PrintError("ERROR WRITING IN FILE: " + ex.Message);
    }

    try
    {
        ExtendedConsole.PrintInColor("--------- Read ---------\n");
        ReadTextFromFileSafe(FilePath);
    }
    catch (Exception ex)
    {
        ExtendedConsole.PrintError("ERROR READING FILE: " + ex.Message);
    }
}
#endregion


#region Dispose with our own disposable class
void AppendTextInFileOurImplementation(string text, string path)
{
    using (OurWriter ourWriter = new OurWriter(path))
    {
        ourWriter.Write(text);
    }
}

void ReadTextFromFileOurImplementation(string path)
{
    using (OurReader ourReader = new OurReader(path))
    {
        Console.WriteLine(ourReader.Read()); 
    }
}


void OurDisposeExample()
{
    try
    {
        ExtendedConsole.PrintInColor("Enter text pt1:");
        string text1 = Console.ReadLine();
        AppendTextInFileOurImplementation(text1, FilePath);

        ExtendedConsole.PrintInColor("Enter text pt2:");
        string text2 = Console.ReadLine();
        AppendTextInFileOurImplementation(text2, FilePath);

        ExtendedConsole.PrintInColor("Enter text pt3:");
        string text3 = Console.ReadLine();
        AppendTextInFileOurImplementation(text3, FilePath);
    }
    catch (Exception ex)
    {
        ExtendedConsole.PrintError("ERROR WRITING IN FILE: " + ex.Message);
    }

    try
    {
        ExtendedConsole.PrintInColor("--------- Read ---------\n");
        ReadTextFromFileOurImplementation(FilePath);
    }
    catch (Exception ex)
    {
        ExtendedConsole.PrintError("ERROR READING FILE: " + ex.Message);
    }
}
#endregion


//ManualDisposeExample();
//UsingBlockDisposeExample();
OurDisposeExample();


Console.ReadLine();