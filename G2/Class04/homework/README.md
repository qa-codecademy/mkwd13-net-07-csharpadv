# Class 4 Homework 📒
## Task 1

Create class PrintInConsole that will have multiple methods to print in console. Print(), PrintCollection().
Make this methods to be valid for more that one type and reuse the implenetation (hint: make them generic);

## Task 2
From the previos homework get the implementation and do not change the implementation of the classes.
Now we need to add couple methods
* Car class should have Drive() method;
* MotorBike should have Wheelie() method;
* Boat should have Sail() method;
* Airplane should habe Fly() method;
* 
```
// this goes after the code from the previous task
car.Drive();
motorBike.Wheelie();
boat.Sail();
plane.Fly();

//Console output
// Driving
// Driving on one wheel
// Saling
// Flying
```

#### Previous homework requirements
Create a class Vehicle that have one method DisplayInfo(). Create class Car, MotorBike, Boat, Airplane that will inherit from Vehicle and will implement the respective method;

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
