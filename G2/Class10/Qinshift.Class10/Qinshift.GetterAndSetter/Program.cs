

using Qinshift.GetterAndSetter;

User user = new()
{
    FullName = "Martin Panovski",
    Age = 20,
    Grades = new List<int> { 10, 9, 6, 6, 7 }
};

Console.WriteLine($"Users GPA: {user.GPA}");


