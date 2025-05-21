using Qinshift.Helpers;

ConsoleHelper.WriteInColor("\n================== FILE STREAMS ==================\n", ConsoleColor.Blue);
// File streams allow you to work with data in a more controlled, efficient, and memory-friendly way.
// NOTE: Working with files is generally considered a "heavy" operation that can consume significant processing resources.

// Benefits of using File Streams:
// - More control over how data is read/written (buffering, encoding, file mode, etc.)
// - Efficient memory usage (especially for large files)
// - Useful for reading/writing large files line by line or in chunks

// SETUP
string folderPath = @"..\..\..\TestFiles";

if (!Directory.Exists(folderPath))
{
    Directory.CreateDirectory(folderPath);
}

string fileName = "notes.txt";
string fileFullPath = Path.Combine(folderPath, fileName);



ConsoleHelper.WriteInColor("\n================== StreamWriter ==================\n", ConsoleColor.Cyan);
// StreamWriter is better than File.WriteAllText for writing large files or writing data gradually (line by line).
// It gives you control over buffering and encoding.

// The 'using' closes the connection made to the file automatically
// The file is created automatically when using StreamWriter
using (StreamWriter streamWriter = new StreamWriter(fileFullPath))
{
    streamWriter.WriteLine("This is a sample note.");
    streamWriter.WriteLine("StreamWriter lets us write text line-by-line efficiently.");
    streamWriter.WriteLine("It also allows you to append or overwrite");
}

using (StreamWriter streamWriter = new StreamWriter(fileFullPath, append: true))
{
    streamWriter.WriteLine("This is ANOTHER note.");
    streamWriter.WriteLine("StreamWriter IS AWESOME !");
}


ConsoleHelper.WriteInColor("\n================== StreamReader ==================\n", ConsoleColor.Cyan);
// StreamReader is better than File.ReadAllText for large files or reading line-by-line.
// It reads the file gradually, reducing memory usage for large content.

try
{
    using (StreamReader streamReader = new StreamReader(fileFullPath))
    {
        ConsoleHelper.WriteInColor("Reading file content using StreamReader: \n", ConsoleColor.Yellow);

        // ===> Read lines one at a time
        //string firstLine = streamReader.ReadLine();
        //Console.WriteLine("First line: " + firstLine);

        //string secondLine = streamReader.ReadLine();
        //Console.WriteLine("Second line: " + secondLine);

        //string thirdLine = streamReader.ReadLine();
        //Console.WriteLine("Third line: " + thirdLine);

        // ===> Read lines one at a time dynamically (until there are any)
        string line = streamReader.ReadLine();
        while (line != null)
        {
            Console.WriteLine(line);
            line = streamReader.ReadLine();
        }
    }
}
catch (Exception ex)
{
    ConsoleHelper.WriteInColor("Error reading file: " + ex.Message, ConsoleColor.Red);
}

Console.ReadLine();