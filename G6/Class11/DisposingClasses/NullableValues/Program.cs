using NullableValues;

Person person = new Person();
Console.WriteLine(person.Id); //0 by default
Console.WriteLine(person.Score); //null by default

if(person.Score == null) //if(!person.Score.HasValue)
{
    Console.WriteLine("Score is null");
}

if (!person.Score.HasValue) //if(person.Score == null)
{
    Console.WriteLine("Score is null");
}

if(person.Score != null) //if(person.Score.HasValue)
{
    Console.WriteLine(person.Score);
}

if (person.Score.HasValue) //(person.Score != null)
{
    Console.WriteLine(person.Score);

    //int score = person.Score; //ERROR - person.Score is nullable int (int?), we cannot assign it to a non-nullable int (int)
    int score = person.Score.Value; //with value we access the value if there is one (that is why first we did a check with HasValue)
}

//person.Id = null; //ERROR - Id is a non-nullable int
person.Score = null; //this is okay
//person.IsStudent = null; //ERROR - IsStudent is a non-nullable bool
person.IsEmployed = null;
person.IsEmployed = false;
person.IsEmployed = true;

Person secondPerson = new Person();
secondPerson = null; //every object is nullable

//? is an operatir that checks for null values. If the left side of the operator is null it returns null as result instead of throwing an exception
//if the left side is not null, it will access the property or method of the object
string name = secondPerson?.Name; //secondPerson == null ? null : secondPerson.Name