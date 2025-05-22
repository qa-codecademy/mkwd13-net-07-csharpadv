


string appPath = @"..\..\..\";
string folderPath = appPath + @"MyFolder\";
string filePath = folderPath + @"test.txt";

// Could also concatinate paths using Path.Combine()
//string filePath = Path.Combine(folderPath, "test.txt");
//Console.WriteLine(filePath);

if (!Directory.Exists(folderPath))
{
    Directory.CreateDirectory(folderPath);
    Console.WriteLine("New directory was created!");
}

#region Writing with StreamWriter

using (StreamWriter sw = new StreamWriter(filePath))
{
    sw.WriteLine("Hello Qinshift Academy!");
    sw.WriteLine("This is a new line added in the same file!");
    Console.WriteLine("Writing in a file completed!");
}


using(StreamWriter sw = new StreamWriter(filePath, true))
{
    sw.WriteLine("This is another text added to the file!");
    sw.Write(" I hope that it will not override the prevoius text!");
    
    Console.WriteLine("Writing in a file completed one more time!");
}


using (StreamReader sr = new StreamReader(filePath))
{
    //string firstLine = sr.ReadLine();
    //string secondLine = sr.ReadLine();

    string fileContent = sr.ReadToEnd();

    //Console.WriteLine($"First line: {firstLine}");
    //Console.WriteLine($"Second line: {secondLine}");
    Console.WriteLine($"Rest content: {fileContent}");

}




#endregion