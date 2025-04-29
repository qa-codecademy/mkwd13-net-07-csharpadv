using AbstractClassesAndInterfaces.Domain.Models;

Developer firstDeveloper = new Developer("Petko P", 26, "Some address", 070123456, "Qinshift", 4, null);
//Person person = new Person(); //ERROR -> abstract class
firstDeveloper.PrintInfo(); //we call the impl from the Person class
Console.WriteLine(firstDeveloper.GetProfessionalInfo()); //here we call the impl from the Developer

JuniorDeveloper junior = new JuniorDeveloper("Nikola N", 30, "Some address2", 070654321, "Qinshift", 4, null, false);
Console.WriteLine(junior.GetProfessionalInfo());
junior.PrintInfo();

//inherited from Person
firstDeveloper.Greet();
firstDeveloper.SendGift("flowers");

//the method that was implented because Developer implements IDeveloper
firstDeveloper.Code();
junior.Code();
//junior.TestingFeatures(); //ERROR -> Developer does not implement IQAEngineer interface

QAEngineer qAEngineer = new QAEngineer("Marko M", 30, "Some address 3", 070987654, 3, new List<string>());
//methods inherited from Person
qAEngineer.Greet();
qAEngineer.SendGift("gift card");

//this method is implemented because QAEngineer implements IQAEngineer
qAEngineer.TestingFeature("search", DateTime.Now.AddDays(3));

//comes from IDeveloper interface
qAEngineer.Code();

DevOpsEngineer devOpsEngineer = new DevOpsEngineer("Petko P", 26, "Some address 4", 070123456, true, false);

//inherited from Person, comes from IPerson
devOpsEngineer.Greet();

//comes from IDeveloper interface
devOpsEngineer.Code();

//comes from IDevOpsEngineer interface
Console.WriteLine(devOpsEngineer.CheckInfrastructure(500));

//BOXING AND UNBOXING 

Developer developer = new Developer("Petko P", 26, "Some address", 070123456, "Qinshift", 4, null);

//Boxing
Person person = (Person)developer;

//Unboxing 
Developer dev = (Developer)person;

//List<Developer> = new List<Developer>() { developer, junior, qAEngineer};
//List < QAEngineer > = new List<QAEngineer>() { developer, junior, qAEngineer };

//Boxing all children to parent Person class, so that they can fit in one List of the same type
List<Person> employees = new List<Person>() { developer, devOpsEngineer, qAEngineer, junior };

foreach(Person p in employees)
{
    Console.WriteLine(p.FullName + " " + p.Age);
}