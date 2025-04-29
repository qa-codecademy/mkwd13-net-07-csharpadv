# Class 3 Homework 📒
## Task 1

Create a class User that will have 3 properties Id, Name, Age.


Create a static class UserDatabase that will contain a list of Users (create a couple of users and add them to the list).


Create a method (or methods) Search() that will search the UserDatabase by Id, Name and Age and will return users as a result. 

## Task 2

Create a class Vehicle that has one method DisplayInfo().

Create classes Car, MotorBike, Boat, Airplane that will inherit from Vehicle and will implement the respective method.

```
Vehicle car = new Car();
Vehicle motorBike = new MotorBike();
Vehicle boat = new Boat();
Vehicle plane = new Airplane();

car.DisplayInfo();
motorBike.DisplayInfo();
boat.DisplayInfo();
plane.DisplayInfo()

// in the console we should display
// Im a car and i drive on 4 wheels :)
// Im a motorbike and i drive on 2 wheels :)
// Im a boat and i do not have wheels :(
// Im a plane and i have a couple of wheels :)
```
