using StaticClasses.Domain.Models;
using StaticClasses.Domain.Enums;
using StaticClasses.Domain;
using StaticClasses.Domain.Helpers;

Order order = new Order(0, "First order", "Our first order", OrderStatusEnum.Created);
Console.WriteLine(order.Description); //we access the non-static member using the object (instance)
order.PrintTitle(); //we call this method using the order object (instance)

Order.IsValid(order); //because the method IsValid is a static method we need to call (access) this method using the class

//Array.Reverse(); we used this before to access the static method Reverse()

Console.WriteLine("Welcome to our ordering app");
Console.WriteLine("Choose the number of your user:");

OrdersDb.PrintUsers();
string input = Console.ReadLine();

//validation
int userChoice = TextHelper.ValidateInput(input);

//because our Orders list is a static list in a static class we need to access it by the class name
Order lastOrder = OrdersDb.Orders.LastOrDefault();
if (lastOrder != null)
{
    Console.WriteLine("The last id of the order is: " + lastOrder.Id);
}

if(userChoice == -1)
{
    Console.WriteLine("Invalid input");
}
else
{
    User currentUser = OrdersDb.Users[userChoice - 1]; //the user choices are order numbers from 1,2.... while the indexes are 0,1...
    if(currentUser == null) //if the user entered a number, but a number that was not on the list (the number validation was okay, but the choice was not correct)
    {
        throw new Exception("User does not exist!");
    }
    Console.WriteLine("Choose an option:");
    Console.WriteLine("1. Print your orders");
    Console.WriteLine("2. Add new order");
    string optionInput = Console.ReadLine();

    int optionChoice = TextHelper.ValidateInput(optionInput);
    if(optionChoice == -1)
    {
        Console.WriteLine("Invalid input");
    }
    else
    {
        if(optionChoice == 1)
        {
            currentUser.PrintOrders(); //User is a standard class and PrintOrders is a standard method so we call the method using the object (instance) - currentUser
        }
        else if(optionChoice == 2)
        {
            //1. enter data for the new order
            Console.WriteLine("Enter title:");
            string titleInput = Console.ReadLine();
            Console.WriteLine("Enter description:");
            string descriptionInput = Console.ReadLine();

            //2. validate the data
            if(string.IsNullOrEmpty(titleInput) || string.IsNullOrEmpty(descriptionInput))
            {
                throw new Exception("Title and description must not be null");
            }

            //3. create the order instance
            Order newOrder = new Order();
            newOrder.Title = titleInput;
            newOrder.Description = descriptionInput;
            newOrder.PrintTitle(); //PrintTitle is not a static method, so we call it with the object
            Order.IsValid(newOrder); //IsValid is a static method so we call it with the class

            //4. add the order to the database
            OrdersDb.InsertOrder(currentUser.Id, newOrder);
            Console.WriteLine("Successfully added new order");
            currentUser.PrintOrders();
        }
    }
}