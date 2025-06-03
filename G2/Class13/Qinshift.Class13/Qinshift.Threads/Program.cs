void SendMessages()
{
    Console.WriteLine("Getting ready...");
    Thread.Sleep(1000);
    Console.WriteLine("First message arrived!");
    Thread.Sleep(1000);
    Console.WriteLine("Second message arrived!");
    Thread.Sleep(1000);
    Console.WriteLine("Third message arrived!");
    Console.WriteLine("All messages are recieved!");
    Console.ReadLine();
}


void SendMessagesWithThreads()
{
    Console.WriteLine("Getting Ready...");

    Thread myThread = new Thread(() =>
    {
        Thread.Sleep(2000);
        Console.WriteLine("First message arrived!");
    });
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
    Console.ReadLine();
}


//SendMessages();
SendMessagesWithThreads();