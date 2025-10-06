using App;

//The User class is likely defined within this namespace.

//Declares and initializes a variable named users as a list ,new List<User>() constructor creates an empty list object in memory.
List<User> users = new List<User>();
// User new_user = new User("user@gmail.com", "pass");
// User class constructor to create a user with the provided email and password
users.Add(new User("Trading@finna.se", "p@ssword"));
users.Add(new User("Aa", "123 "));

foreach (User user in users)
{
    Console.WriteLine(user.Email);
}
//Declares and initializes a variable named items as a list
// List<string> items = new List<string>();

// items.Add("Sliver ring, jade");          //items list using the List<T>.Add() method.
// items.Add("Gold ring, pearl");
// items.Add("Bracelet, ruby");
// items.Add("Necklet, opal");


// Console.WriteLine("Checking if my items still exits");
// Console.ReadLine();

// foreach (string item in items)   //  loop that iterates over every string in the items
// {
//     Console.WriteLine(item);
//     Console.ReadLine();

// }

// User? active_user = null;    //It is initialized to null, meaning no user is currently logged in.

// bool running = true;    // This variable controls the main application loop.

// while (running)   // The code inside the curly braces will execute repeatedly as long as the condition is true
// {
//     Console.Clear();
//     if (active_user != null)      //Checks if a user is currently logged in 
//     {
//         Console.WriteLine("Welcome to Trading finna , Let's trading ");   // welcome messages to the console for a logged-in user.(if user log in)

//     }
//     else if (active_user == null)    // in case no one is logged in so system run again and ask user to login
//     {
//         Console.Write("Username : ");        //User will see this if user success login
//         string? username = Console.ReadLine();

//         Console.Write("Password: ");
//         string? password = Console.ReadLine();
//         Console.Clear();    


//         foreach (User user in users)       //iterates through every User obj in users list ,check if the entered credentials match any stored user.
//         {
//             if (user.TryLogin(username!, password!))   //This method is assumed to return true if the login is successful
//             {
//                 active_user = user;    //If TryLogin() returns true -success user
//                 break;   //Exits the innermost loop (foreach loop) immediately after a successful login,
//             }
//         }
//     }
//     else
//     {
//         Console.WriteLine("Username or passwprd wrong");
//     }
// }






// var thing = "something";
// var thing2 = new String("something");

// User user = new User("email", "password");

// // if
// // for
// // while
// // do....while

// if (1 > 2) {
//     Console.WriteLine("false");
// } else if (2 > 1) {
//     Console.WriteLine("true");
// } else {
//     Console.WriteLine("Dog");
// }

// // try - catch

// string number = "5";

// try
// {
//     int.Parse(number);
//     Console.WriteLine($"{number} parsed succssfuly");
// } catch (Exception error) {
//     Console.WriteLine(error);
// } finally {
//     Console.WriteLine("This message will be printed every time");
// }

// // methods and functions (methods == functions)

// string FunctionsName(string argument1)
// {
//     Console.WriteLine(argument1);
//     return argument1;  
// }

// FunctionsName(number);