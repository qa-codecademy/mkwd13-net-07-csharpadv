string appPath = @"..\..\..\";
string myFolder = appPath + "myFolder";
string txtPath = myFolder + @"\test.txt";

if (!Directory.Exists(myFolder))
{
    Directory.CreateDirectory(myFolder);
}

//if the test.txt file does not exist, Stream writer creates it for us
using(StreamWriter sw = new StreamWriter(txtPath))
{
    sw.WriteLine("Hello G6!");
    sw.WriteLine("We are writing from stream writer");
}
//sw only exists and can be used inside the using blcok {}
//after the } sw object is disposed and the connection with the file system is closed


//here we are opening a new stream
//if there is already some text it will be overwritten
using (StreamWriter sw = new StreamWriter(txtPath))
{
    sw.WriteLine("Another text");
    sw.WriteLine("This is another line");
    sw.WriteLine("This is yet another line");
}

using(StreamWriter sw = new StreamWriter(txtPath, true))
{
    sw.WriteLine("This is appended text");
}


//reading
using(StreamReader sr = new StreamReader(txtPath))
{
    string firstLine = sr.ReadLine();
    string secondLine = sr.ReadLine();
    string restOfTheText = sr.ReadToEnd();

    Console.WriteLine(firstLine);
    Console.WriteLine(secondLine);
    Console.WriteLine(restOfTheText);
}