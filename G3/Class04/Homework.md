# Class 4 Bonus Exercises 📒

## Task 1

* Create class PrintInConsole that will have multiple methods to print in console: Print(), PrintCollection().
* Make these methods to be valid for more than one type and use them accordingly with different types.

## Task 2

* Create a class Vehicle that has one method DisplayInfo(). 
* Create class Car, MotorBike, Boat, Airplane that will inherit from Vehicle and will implement the respective method.

```
Vehicle car = new Car();
Vehicle motorBike = new MotorBike();
Vehicle boat = new Boat();
Vehicle plane = new Airplane();

car.DisplayInfo();
motorBike.DisplayInfo();
boat.DisplayInfo();
plane.DisplayInfo()

// in console we should display
// Im a car and i drive on 4 wheels :)
// Im a motorbike and i drive on 2 wheels :)
// Im a boat and i do not have wheels :(
// Im a plane i have couple of wheels :)
```

## Task 3

From the previous task get the implementation and DO NOT CHANGE the implementation of the classes.

Now we need to EXTEND the functionalities with a couple of methods:
* Car objects should have Drive() method;
* MotorBike should have Wheelie() method;
* Boat should have Sail() method;
* Airplane should have Fly() method; <br>

```
// this goes after the code from the previous task
car.Drive();
motorBike.Wheelie();
boat.Sail();
plane.Fly();

//Console output
// The car is driving
// The motorbike is driving on one wheel
// The boat is sailing
// The airplane is flying
```
