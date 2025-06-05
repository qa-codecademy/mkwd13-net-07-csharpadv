

void SendMessage(string message)
{
    Console.WriteLine("Sending message...");
    Thread.Sleep(7000);
    Console.WriteLine($"The message '{message}' was sent!");
}

async Task SendMessageAsync(string message)
{
    Console.WriteLine("Sending message...");
    await Task.Run(() =>
    {
        Thread.Sleep(7000);
        Console.WriteLine($"The message {message} was sent!");
    });
}

//async Task<string> SendMessageAsyncWithStatus(string message)
//{
//    Console.WriteLine("Sending message...");

//    await Task.Run(() =>
//    {
//        Thread.Sleep(7000);
//        return $"The message {message} was sent!";
//    });
//    return "Something went wrong!";
//}

void ShowAd(string product)
{
    Console.WriteLine("While you wait let us show you an ad!");
    Thread.Sleep(1000);
    Console.WriteLine("Buy the best product in the world ");
    Thread.Sleep(1000);

    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.Write(product);
    Console.ResetColor();
    Thread.Sleep(1000);

    Console.Write(" now and get ");
    Console.ForegroundColor = ConsoleColor.Green;
    Thread.Sleep(1000);

    Console.Write("FREE");
    Console.ResetColor();
    Thread.Sleep(1000);

    Console.WriteLine(" shipping worldwide!");
    Console.ReadLine();
}


async Task SayHello(string person)
{
    Console.WriteLine($"Hello there {person}");
}



//SendMessage("Hello there!");

var x = SendMessageAsync("Hello, how are you?");
Console.WriteLine(x.Status);

ShowAd("Potato");
Console.ReadLine();

Console.WriteLine(x.Status);


