string currentDirectory = Directory.GetCurrentDirectory();
Console.WriteLine(currentDirectory); //absoulte path C:\Users\stoja\OneDrive\Desktop\SEDC\C# Advanced 2025\students\G6\Class10\Code\WorkingWithFileSystem\bin\Debug\net8.0

string appPath = @"..\..\..\"; //relative path to the console app folder

//check if this path exists: ..\..\..\myFolder (check if three levels above there is a folder named myFolder)
bool myFolderExists = Directory.Exists(appPath + "myFolder"); //here we pass the path that we want to check if it exists
Console.WriteLine(myFolderExists);

string newFolderPath = appPath + "newFolder";
if (!Directory.Exists(newFolderPath)) //if this newFolder does not exist at this location (this path)
{
    Directory.CreateDirectory(newFolderPath); //here we send the path where we want to create the new directory (folder)
    Console.WriteLine("New folder sucessfully created");
}

Console.WriteLine(Directory.Exists(newFolderPath)); //now it should be true

if (Directory.Exists(newFolderPath)) //always check that the path exists before trying to delete it
{
   //Directory.Delete(newFolderPath); //here we send the path that we want to delete
    Console.WriteLine("New folder successfully deleted");
}

//Working with files
if(!Directory.Exists(appPath + "myFolder"))
{
    Directory.CreateDirectory(appPath + "myFolder");
}

//check if a file test.txt exists on ..\..\..\myFolder\test.txt
bool testtxtExists = File.Exists(appPath + @"myFolder\test.txt");
Console.WriteLine(testtxtExists);

if (!testtxtExists)
{
    File.Create(appPath + @"myFolder\test.txt").Close(); //Create returns a FileStream that we need to close
}

if (File.Exists(appPath + @"myFolder\test.txt")) //check if the file was successfully created
{
    //overwrite the content of test.txt
    File.WriteAllText(appPath + @"myFolder\test.txt", "Hello G6");
}

if (File.Exists(appPath + @"myFolder\test.txt")) //check if the file was successfully created
{
    //overwrite the content of test.txt
    File.WriteAllText(appPath + @"myFolder\test.txt", "Hello again G6! This is another text that is written in test.txt");
}

if(File.Exists(appPath + @"myFolder\test.txt"))
{
    //this will append the text to the content og test.txt
    File.AppendAllText(appPath + @"myFolder\test.txt", Environment.NewLine + "Goodbye G6!");
}

if (File.Exists(appPath + @"myFolder\test.txt"))
{
    //this will append the text to the content og test.txt
    File.AppendAllText(appPath + @"myFolder\test.txt", Environment.NewLine + "See you next Tuesday");
}

if(File.Exists(appPath + @"myFolder\test.txt"))
{
    //we need to tell the path that we want to read from
    string fileContent = File.ReadAllText(appPath + @"myFolder\test.txt");
    Console.WriteLine("=======================");
    Console.WriteLine(fileContent);
}

if (File.Exists(appPath + @"myFolder\test.txt"))
{
    File.Delete(appPath + @"myFolder\test.txt");
}