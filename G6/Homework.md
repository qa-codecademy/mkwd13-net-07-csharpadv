# Time tracking app ⏳

Time is one of the most valuable resources on the planet. When we learn, work, spend time with our friends, we always do it in increments of time. That is why organizing it and tracking it can have positive results on productivity in general. We need an app that can track the time of the users when they are doing something, save it and compile statistics for the time spent.

## Features 🎈

* Log in and Register option
* Log out option
* Back to Main Menu option
* Tracking time for a certain activity ( Start and Stop option )
* User statistics
* Set of predefined activities with specific values
* Account management
  * Change password
  * Change First and Last name
  * **BONUS:** Deactivate account

## Requirements 📌

* **Login and Register**
  * Register Information
    * First Name
    * Last Name
    * Age
    * Username
    * Password
  * Validations
    * Username should not be shorter than 5 characters
    * Password should not be shorter than 6 characters
    * **BONUS:** Password should contain at least one capital letter
    * **BONUS:** Password should contain at least one number
    * **BONUS:** First Name and Last Name should not contain numbers
    * First Name and Last Name should not be shorter than 2 characters
    * Age should not be less than 18 years or over 120
  * **BONUS:** If the user do not guess their username and password 3 times, the application should close with a goodbye message
* **Log Out**
  * Should be available on the main menu
  * When logged out, the login menu should open again
* **Track**
  * Should be available on the main menu
  * Should open a list of activities available for tracking
    * Reading
      * Extra info: Pages
      * Extra info: Type
        * Belles Lettres
        * Fiction
        * Professional Literature
      * Exercising
      * Extra info: Type
        * General
        * Running
        * Sport
      * Working
        * Extra info: At the office or From home
      * Other Hobbies
      * Extra Info: Name of hobby
* **How is the tracking done**
  * Each activity is tracked in time spent doing the activity
  * Time is tracked when:
    * The user selects an activity and a message is shown that the countdown for that activity is started
    * The user needs to hit enter for the timer to be stopped and the time to be saved for that activity
    * The user also needs to fill in some extra info depending on the activity they chose
  * After the user hits enter and fills in the extra info a message shows with the time they spent in minutes
  * When the user hits enter after the message with the time, they are redirected to the main menu again
  * Each activity is tracked separately for each user
* **User Statistics** ( HOMEWORK PART 2 )
  * Should be available in the main menu
  * When the user chooses this they should get a new menu with options
    * Reading
      * Total time ( in hours )
      * **BONUS:** Average of all activity records ( in minutes )
      * Total number of pages
      * Favorite Type - The type which has the most registered records of activity
    * Exercising
      * Total time ( in hours )
      * **BONUS:** Average of all activity records ( in minutes )
      * Favorite Type - The type which has the most registered records of activity
    * Working
      * Total time ( in hours )
      * **BONUS:** Average of all activity records ( in minutes )
      * Home VS Office working ( in hours )
    * Hobbies
      * Total time ( in hours )
      * **BONUS:** List of all recorded names of hobbies ( Do not show duplicates )
    * Global
      * Total time of all activities ( in hours )
      * What is the user favorite activity
* **Account Management** ( HOMEWORK PART 2 )
  * Should be available in the main menu
  * Should have the option to:
    * Change password
    * Change FirstName
    * Change LastName
  * **BONUS:** Deactivate account
    * **BONUS:** Should flag the user as deactivated and the user should not be able to log in
    * **BONUS:** When the user logs in but their account is deactivated there should be a question on whether the user wants to activate their account again
* **Back Option** ( HOMEWORK PART 2 )
  * This option should be available on the Statistics, Account Management, and Activities menu
  * The option should redirect the user back to the main menu
* **Menu Validations** ( HOMEWORK PART 2 )
  * All menus should be validated by not allowing the user to enter anything but numbers
  * The numbers should be validated so the user can only enter numbers that are given as options
  * Error messages should appear when the user enters incorrect info in red text
  * When the user successfully register, log in or change their info, they should receive a green success message
* **Save Progress** ( HOMEWORK 3 )
  * The application should save progress even when the application is closed and opened again
