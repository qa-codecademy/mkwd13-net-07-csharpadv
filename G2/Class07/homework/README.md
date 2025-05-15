# Class 7 Homework 📒
## Task 1
Create console application TeacherNotificator. 
Create folder Models and add 2 classes in it: 
 1. Students with the following properties:
   Name, Age, Email, Subject
   and one method void GetNotification(string) which will print Name of the student + text from parameter

 2. Teacher with the following properties:
   Name, Age, Email, Subject
   add event here. 
   add 2 methods subscribe and unsubscribe and print text for the action. ex:"Alice subscribed to Professor John's notifications."
   add method void SendNotification() which will print "Sending Notifications to all students..." and invoke the event here. 

In the program class create 1 professor and 3 students.
subscribe all students to the event
executes professor.SendNotification() in order to invoke the event. 
Unsubscribe the 2 students and execute the professor.SendNotification() again


the expected output:
Alice subscribed to Professor John's notifications.
Bob subscribed to Professor John's notifications.
Charlie subscribed to Professor John's notifications.

Sending notifications....
Alice: Notification from Professor John: Class for Math will start at 10 AM.
Bob: Notification from Professor John: Class for Math will start at 10 AM.
Charlie: Notification from Professor John: Class for Math will start at 10 AM.

Alice unsubscribed from Professor John's notifications.
Charlie unsubscribed from Professor John's notifications.

Sending notifications....
Bob: Notification from Professor John: Class for Math will start at 10 AM.

## Task 2

Write a program for Online Classes. The conditions are as follow:
* User provides their name as Input and then application show message to “Welcome to their Name”.
* Bob, Jill, and Alice does not have permissions to attend this class. So, when any user enters Bob, Jill, or Alice as username, the application raised an event and fire alarm as well as sends email to administration.

Expected output
Case 1: 
    Welcome Charlie.
Case 2: 
    Alice Users Found. Sending Email to Administration.
    Email Sent.
    Warning Alarm Started.
    Loging out.
            
            
            
            
            