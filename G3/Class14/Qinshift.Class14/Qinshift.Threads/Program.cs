Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("\n================= THREADS =================\n\n");
Console.ResetColor();
// Thread is a path of execution within a process
// They are the smallest unit of execution that can be scheduled by an operating system
// They allow a program to perform multiple tasks concurrently (at same time)

// Synchronous
void SendMessages()
{
    Console.WriteLine("Getting Ready...");
    Thread.Sleep(2000);
    Console.WriteLine("First message arrived!");
    Thread.Sleep(2000);
    Console.WriteLine("Second message arrived!");
    Thread.Sleep(2000);
    Console.WriteLine("Third message arrived!");
    Console.WriteLine("All messages are received!");
}

// Asynchronous
void SendMessagesWithThreadsAsync()
{
    Console.WriteLine("Getting Ready...");
    Thread myThread = new Thread(() =>
    {
        Thread.Sleep(2000);
        Console.WriteLine("First message arrived!");
    });
    Console.WriteLine(myThread.ThreadState);
    myThread.Start();

    new Thread(() =>
    {
        Thread.Sleep(2000);
        Console.WriteLine("Second message arrived!");
    }).Start();

    new Thread(() =>
    {
        Thread.Sleep(2000);
        Console.WriteLine("Third message arrived!");
    }).Start();

    Console.WriteLine("All messages are recieved!");
}

// ===> Synchronous execution
//SendMessages();

// ===> Asynchronous execution
SendMessagesWithThreadsAsync();


Console.ReadLine();