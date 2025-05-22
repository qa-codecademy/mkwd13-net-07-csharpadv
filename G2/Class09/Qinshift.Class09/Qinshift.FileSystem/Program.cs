

string currentDirectory = Directory.GetCurrentDirectory();
Console.WriteLine(currentDirectory);

#region DirectoryManipulation - Directory
// Relative path to our application
string relativePath = @"..\..\..\";
Console.WriteLine(relativePath);

// Absolute path to our application
string absolutePath = "D:\\SEDC\\2024-2025\\7. Advanced C#\\mkwd13-net-07-csharpadv\\G2\\Class09\\Qinshift.Class09\\Qinshift.FileSystem";
Console.WriteLine(absolutePath);

// Create new folder
Console.WriteLine("=================== Create new Directory ==============");
bool ifDemoFolderExists = Directory.Exists(relativePath + @"DemoFolder");
bool ifDemoFolderExistsString = Directory.Exists(absolutePath + @"DemoFolder");

Console.WriteLine($"Does DemoFolder exists: {ifDemoFolderExists}");
Console.WriteLine($"Does DemoFolder absolute path exists: {ifDemoFolderExistsString}");






string demoFolderPath = relativePath + @"DemoFolder";
Console.WriteLine($"Does DemoFolder exists before: {Directory.Exists(demoFolderPath)}");
if (!Directory.Exists(demoFolderPath))
{
    Directory.CreateDirectory(demoFolderPath);
    Console.WriteLine("New directory was created!");
}
Console.WriteLine($"Does DemoFolder exists after: {Directory.Exists(demoFolderPath)}");


//Console.WriteLine("Press any key to delete the folder!");
//Console.ReadLine();

//if (Directory.Exists(demoFolderPath))
//{
//    Directory.Delete(demoFolderPath);
//    Console.ForegroundColor = ConsoleColor.Red;
//    Console.WriteLine("DemoFolder was deleted!");
//    Console.ResetColor();
//}

//Console.ReadLine();
#endregion


#region FileManipulation - File
Console.ReadLine();
string folderPath = relativePath + @"DemoFolder_1\";
string filePath = folderPath + @"demo.txt";
if (!Directory.Exists(folderPath))
{
    Directory.CreateDirectory(folderPath);
    Console.WriteLine("A new folder has been created!");
}

// File Create

if (!File.Exists(folderPath + @"demo.txt"))
{
    File.Create(folderPath + @"demo.txt").Close();
    Console.WriteLine("A file was created!");
}

// File Delete
//if (File.Exists(folderPath + @"demo.txt"))
//{
//    File.Delete(folderPath + @"demo.txt");
//    Console.WriteLine("A file was deleted!");
//}


// Write in file
if(File.Exists(folderPath + @"demo.txt"))
{
    File.WriteAllText(filePath, "Hello there! We are learning how to insert text in file and it is awesome!");
    Console.WriteLine("Successfully written in a file!");
}


// Read from file
if (File.Exists(filePath))
{
    string content = File.ReadAllText(filePath);
    Console.WriteLine("This content comes from a file!");
    Console.WriteLine(content);
}


#endregion