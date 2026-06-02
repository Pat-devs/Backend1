// On program start we show user a greeting or a menu
//Console.WriteLine("Welcome to our app!");
//Console.WriteLine();

// A simple calculator
// 1. Greeting (tell user what they can do) 
// 2. Ask user for first number
// 3. Ask user for second number
// 4. Show user the sum of the two numbers

Console.WriteLine("Sum of two numbers (a simple calculator)");
Console.WriteLine("Enter the first number");
// prompt user for the first number and store it in a variable
int firstNumber = int.Parse(Console.ReadLine());

// small check if it works :)
Console.WriteLine("user entered: " + firstNumber);