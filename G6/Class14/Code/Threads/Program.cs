//synchronous 

void PrintMessagesSynchronous(){
    Console.WriteLine("Hello");
    Console.WriteLine("First message"); //call to api/db 
    Thread.Sleep(3000); //wait for response (wait 3s) - we simulate a call to api by making the current thread "sleep" for 3 seconds
    Console.WriteLine("Second message"); //validation
    Console.WriteLine("Third message"); //using the response
    Console.WriteLine("Bye");
}

//PrintMessagesSynchronous();

void PrintMessagesInDifferentThreads()
{
    Console.WriteLine("Hello"); //this will be executed on the main thread - this is the only line that we know will execute first

    //we dont know the order in which the next lines of code will be executed
    Thread firstThread = new Thread(() =>
    {
        Thread.Sleep(2000);
        Console.WriteLine("First thread");
    });

    //we need to start the thread
    firstThread.Start();

    Thread secondThread = new Thread(() =>
    {
        Thread.Sleep(1000);
        Console.WriteLine("Second thread");
    });

    //we need to start the thread
    secondThread.Start();
}

PrintMessagesInDifferentThreads();