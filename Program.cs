// On program start we show user a greeting or a menu

Console.WriteLine("Welcome to our app!");
Console.WriteLine("Please enter your details.");
Console.WriteLine();
// user data variables

// prompt user for name
Console.WriteLine("Enter your first name: ");
string userName = Console.ReadLine();

// prompt user for age
Console.WriteLine("Enter your age: ");
// since we declare userAge to be an int, but Console.ReadLine returns only strings (ie: "20") we need to use a tool to convert a string to an int.
// for example: .Parse()
// int.Parse("tall"); // syntax example  

int userAge = int.Parse(Console.ReadLine());

userAge = userAge + 2000;

Console.WriteLine(" you are " + userAge + " years old.");