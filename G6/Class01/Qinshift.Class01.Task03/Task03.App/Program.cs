
using Task03.Logic.Enums;
using Task03.Logic.Services;

Console.WriteLine("============ TASK 03 ============");
/*
    ## 3. Create a console application that plays rock-paper-scissors 🔹
    * There should be a menu with three options:
      * Play
        1. The user picks rock, paper, or scissors.
        2. The application picks rock, paper, or scissors at random.
        3. The user's pick and the application's pick are shown on the screen.
        4. The application shows the winner.
        5. The application saves 1 score to the user or the computer in the background.
        6. When the user hits enter, it returns to the main menu.
      * Stats
        1. It shows how many wins the user has and how many wins the computer has.
        2. It shows the percentage of the wins and losses of the user.
        3. When the user hits enter, it returns to the main menu.
      * Exit
        1. It closes the application.
*/
bool isRunning = true;

var gameService = new GameService();

while (isRunning)
{
    Console.Clear();
    Console.WriteLine("===== Rock Paper Scissors =====");
    Console.WriteLine("1) Play");
    Console.WriteLine("2) Stats");
    Console.WriteLine("3) Exit");

    bool isValidOption = Enum.TryParse<MenuOption>(Console.ReadLine(), out MenuOption menuOptionInput);

    if (!isValidOption)
    {
        Console.WriteLine("Select valid option!");
        continue;
    }

    switch (menuOptionInput)
    {
        case MenuOption.Play:
            // Play Game
            break;
        case MenuOption.Stats:
            // Show Stats
            break;
        case MenuOption.Exit:
            isRunning = false;
            break;
    }
}

void PlayGame()
{
    Console.WriteLine("Choose one option:");
    Console.WriteLine("1) Rock");
    Console.WriteLine("2) Paper");
    Console.WriteLine("3) Scissors");

    bool isValidChoice = Enum.TryParse<Choice>(Console.ReadLine(), out Choice userChoice);

    // logic...
}

void ShowStats()
{
    // logic...
}
