//the return type must be Task (depending on the return type of the method we could have Task (void), Task<int>, Task<string>, Task<Student>...)
async Task SendMessage (string message)
{
    Console.WriteLine("Sending a message...");

    //this code in the task is sent away to be executed on another thread 
    //this task could be any code that might take some longer time to execute ex. call to db/api
    //we want the code Console.WriteLine("The message was sent"); to wait for the task to finish before executing
    //that's why we mark the method as async - we release the main thread so other tasks can be executed
   //but we mark this task with await so that the rest of our code waits for the message to be send
    await Task.Run(() =>
    {
        Thread.Sleep(1000); //simulate an operation that lasts at least 1s
        Console.WriteLine("Message " + message);
    });

    Console.WriteLine("The message was sent"); //this line will wait for the task to end before it is executed

}

void ShowAd(string product)
{
    Console.WriteLine("While we are waiting for the message to be sent, let us show you an ad");
    Console.WriteLine($"You can have this product {product} in the next 10 min...");
}

void Done()
{
    Console.WriteLine("The end");
}

//beacuse there is a code that takes longes to be executed in the SendMessage (async - it is executed on a different thread)
//our main thread is free and ShowAdd can be execited there
//SendMessage("Hello G6");
//ShowAd("milk");
//Console.WriteLine("Greetings from main thread"); //this code won't wait for SendMessage to end


await SendMessage("Hello G6"); //when we add await we tell the rest of the code that they need to wait for this method to end
Done();
Console.ReadLine();