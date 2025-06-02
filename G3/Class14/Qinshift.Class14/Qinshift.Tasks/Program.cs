Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("\n================= TASKS =================\n\n");
Console.ResetColor();
// Tasks represent asynchronous operations
// Unlike the threads in C#, Tasks are not opening a new execution path every time
// They get queued to be executed asynchronously by an available thread
// This is done by a system called the ***Thread Pool*** 

Console.WriteLine("App start...\n");

// ===> Single Task Example
Task myTask = new Task(() =>
{
    Thread.Sleep(2000);
    Console.WriteLine("Running after 2000ms");
});
Console.WriteLine(myTask.Status);
myTask.Start();
Console.WriteLine(myTask.Status);
Console.WriteLine(myTask.Status);


// ===> Single task with return type 
Task<int> valueTask = new Task<int>(() =>
{
    Thread.Sleep(2000);
    Console.WriteLine("We can now get the number...");
    return 3;
});
valueTask.Start();
Console.WriteLine(valueTask.Result);


Task.Run(() =>
{
    Thread.Sleep(3000);
    Console.WriteLine("This is executed after 3000ms...");
});


Console.WriteLine("\nApp end...\n");


for (int i = 1; i <= 20; i++)
{
    int temp = i;
    Task.Run(() =>
    {
        Thread.Sleep(2000);
        Console.WriteLine($"TASK NO. {temp}");
    });
}




Console.ReadLine();