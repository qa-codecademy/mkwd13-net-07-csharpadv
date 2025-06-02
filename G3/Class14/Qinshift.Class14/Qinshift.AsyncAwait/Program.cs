using System.Diagnostics;

Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("\n================= ASYNC/AWAIT =================\n\n");
Console.ResetColor();


void SendMessage(string message)
{
    Console.WriteLine("Sending message ...");
    Thread.Sleep(5000);
    Console.WriteLine($@"The message ""{message}"" was sent!");
}

//async void SendMessageAsync(string message)
//{

//}

async Task SendMessageAsync(string message)
{
    Console.WriteLine("Sending message...\n");
    await Task.Run(() => // here with 'await' the program waits for this Task to finish and then prints the message "It takes 7 sec..."
    {
        Thread.Sleep(7000);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($@"The message ""{message}"" was sent!");
        Console.ResetColor();
    });
    Console.WriteLine("It takes 7 seconds...");
}

void ShowAd(string product)
{
    Console.WriteLine("\nWhile you wait let us show you an ad:");
    Console.Write("Buy the best product in the world ");
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.Write(product);
    Console.ResetColor();
    Console.Write(" now and get ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("FREE");
    Console.ResetColor();
    Console.WriteLine(" shipping worldwide!");
}

async Task AwaitExample()
{
    //await SendMessageAsync("Hello there Qinshift Academy students!"); // we don't need to await this method since it doesn't affect the further flow of the program
    SendMessageAsync("Hello there Qinshift Academy students!");
    Console.WriteLine("\nGetting the AD item...");
    //Task adItem = GetAdvertismentItemAsync(); // won't work
    string adItem = await GetAdvertismentItemAsync();
    ShowAd(adItem);
}

async Task<string> GetAdvertismentItemAsync()
{
    Thread.Sleep(11_000);
    return "Keyboard";
}


string message = "Hello there Qinshift Academy students!";

// ===> Example for synchronous execution ( It does not show the ad while we wait )
//SendMessage(message);
//ShowAd("Laptop");

// ===> Example of asynchronous execution
//await SendMessageAsync(message); // waits for the whole method to finish, program DOESN'T continue
//SendMessageAsync(message); // will be executed when the task is finished, program continues
//ShowAd("Laptop");

// ===> We can assign the task to a variable
//Task sendMessageTask = SendMessageAsync(message);


// ===> MainThread method example
Stopwatch stopwatch = Stopwatch.StartNew();

stopwatch.Start();
await AwaitExample();
stopwatch.Stop();

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"\nTotal Time: {stopwatch.ElapsedMilliseconds} ms");
Console.ResetColor();

Console.ReadLine();