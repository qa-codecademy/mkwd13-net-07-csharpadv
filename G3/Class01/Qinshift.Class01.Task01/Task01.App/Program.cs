
Console.WriteLine("============== TASK 01 ==============");
/*
    1. Create a console application that detect provided names in a provided text 
        => The application should ask for names to be entered until the user enteres x
        => After that the application should ask for a text
        => When that is done the application should show how many times each name was included in the text (ignoring upper/lower case)
*/

List<string> names = new List<string>() { "John", "Anna", "mark", "LisA" };

string text = @"
    Once upon a time in a small village, there lived a man named John. John was known for his kindness and generosity.
    His neighbor, Anna, often came by to borrow sugar or just chat. One day, John and Anna decided to organize a small community event.
    They invited their friends Mark and Lisa to help with the arrangements. Lisa baked cookies while Mark handled the music.
    During the event, everyone praised John and Anna for their efforts. Later that evening, John wrote a thank-you note to Lisa and Mark.
    The next day, Mark visited John again, and they talked about how successful the event was.
    Even Anna stopped by with a basket of fruit as a thank-you gift. Everyone agreed that it was a day to remember, thanks to John, Anna, Mark, and Lisa.
";