
using Task02.Logic;

Console.WriteLine("============== TASK 02 ==============");
/*
    2. Create a console application that checks if a day is a working day 
        => The app should request the user to enter a date as input.
        => The app should then check if the day is a working day.
        => It should show the user a message indicating whether the date they've entered is a working day or not.
            => Weekends are not working days.
            => January 1, January 7, April 20, May 1, May 25, August 3, September 8, October 12, October 23, and December 8 are also not working days.
        => It should ask the user if they want to check another date.
            => Yes - the app runs again.
            => No - the app closes. 
*/

var workingDayService = new WorkingDayService();

bool checkAnotherDate = true;

while (checkAnotherDate)
{
    // Ask the user to enter a date
    Console.Write("Enter a date (yyyy-MM-dd): ");
    string userInput = Console.ReadLine();

    bool isValidDate = DateTime.TryParse(userInput, out DateTime dateInput);

    if (!isValidDate)
    {
        Console.WriteLine("Invalid date format. Please try again.");
        continue;
    }
    
    // Check if the entered date is a working day
    bool isWorkingDay = workingDayService.IsWorkingDay(dateInput);

    // Display the result
    if (isWorkingDay)
    {
        Console.WriteLine($"{dateInput:dd/MM/yyyy} is a working day.");
    }
    else
    {
        Console.WriteLine($"{dateInput:dd/MM/yyyy} is NOT a working day.");
    }

    // Ask if the user wants to check another date
    Console.Write("\nDo you want to check another date? (yes/no): ");
    string userResponse = Console.ReadLine()?.ToLower();

    if (userResponse == "no")
    {
        checkAnotherDate = false;
    }
}

Console.WriteLine("Goodbye!");