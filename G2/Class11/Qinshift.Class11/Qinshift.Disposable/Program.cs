using Qinshift.Disposable;
using Qinshift.Helpers;

ExtendedConsole.PrintInColor("\n================== DISPOSING ==================\n\n", ConsoleColor.Cyan);

const string AppPath = @"../../../Text";
const string FilePath = AppPath + @"\text.txt";

void CreateFolder(string path)
{
    if (!Directory.Exists(path))
    {
        Directory.CreateDirectory(path);
    }
}

void CreateFile(string path)
{
    if (!File.Exists(path))
    {
        File.Create(path).Close();
    }
}

CreateFolder(AppPath);
CreateFile(FilePath);


#region Manual Dispose Methods
void AppendTextInFile(string text, string path)
{
    StreamWriter streamWriter = new StreamWriter(path, true);
    streamWriter.WriteLine(text);
    streamWriter.Dispose();
}

void ReadTextFromFile(string path)
{
    StreamReader sr = new StreamReader(path);
    Console.WriteLine(sr.ReadToEnd());
    sr.Dispose();
}

void ManualDisposeExample()
{
    ExtendedConsole.PrintInColor("Enter text part 1:");
    string text1 = Console.ReadLine();
    AppendTextInFile(text1, FilePath);

    ExtendedConsole.PrintInColor("Enter text part 2:");
    string text2 = Console.ReadLine();
    AppendTextInFile(text2, FilePath);

    ExtendedConsole.PrintInColor("Enter text part 3:");
    string text3 = Console.ReadLine();
    AppendTextInFile(text3, FilePath);

    ExtendedConsole.PrintInColor("\n=========== Read =========\n");

    ReadTextFromFile(FilePath);
}

#endregion


#region Dispose with Using Block

void AppendTextInFileSafe(string text, string path)
{
    using StreamWriter streamWriter = new StreamWriter(path, true);
    streamWriter.WriteLine(text);
}

void ReadTextFromFileSafe(string path)
{
    using (StreamReader sr = new StreamReader(path))
    {
        Console.WriteLine(sr.ReadToEnd());
    }
}

void UsingDisposeExample()
{
    ExtendedConsole.PrintInColor("Enter text part 1:");
    string text1 = Console.ReadLine();
    AppendTextInFileSafe(text1, FilePath);

    ExtendedConsole.PrintInColor("Enter text part 2:");
    string text2 = Console.ReadLine();
    AppendTextInFileSafe(text2, FilePath);

    ExtendedConsole.PrintInColor("Enter text part 3:");
    string text3 = Console.ReadLine();
    AppendTextInFileSafe(text3, FilePath);

    ExtendedConsole.PrintInColor("\n=========== Read =========\n");

    ReadTextFromFileSafe(FilePath);
}

#endregion


#region Dispose with our own class

void AppendTextInFileOwn(string text, string path)
{
    using (OurWriter ourWriter = new OurWriter(path))
    {
        ourWriter.Write(text);
    }
}

void ReadTextFromFileOwn(string path)
{
    using (OurReader ourReader = new(path))
    {
        Console.WriteLine(ourReader.Read());
    }
}

void OurDisposeExample()
{
    ExtendedConsole.PrintInColor("Enter text part 1:");
    string text1 = Console.ReadLine();
    AppendTextInFileOwn(text1, FilePath);

    ExtendedConsole.PrintInColor("Enter text part 2:");
    string text2 = Console.ReadLine();
    AppendTextInFileOwn(text2, FilePath);

    ExtendedConsole.PrintInColor("Enter text part 3:");
    string text3 = Console.ReadLine();
    AppendTextInFileOwn(text3, FilePath);

    ExtendedConsole.PrintInColor("\n=========== Read =========\n");

    ReadTextFromFileOwn(FilePath);
}

#endregion


//ManualDisposeExample();
//UsingDisposeExample();
OurDisposeExample();