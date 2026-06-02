// On program start we show user a greeting or a menu
//Console.WriteLine("Welcome to our app!");
//Console.WriteLine();

// A simple calculator
// 1. Greeting (tell user what they can do) 
// 2. Ask user for first number
// 3. Ask user for second number
// 4. Show user the sum of the two numbers

Console.WriteLine("Sum of two numbers (a simple calculator)");
Console.WriteLine("Enter the first number: ");
// prompt user for the first number and store it in a variable
int firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the second number: ");
// prompt user for the second number and store it in a variable
int secondNumber = int.Parse(Console.ReadLine());

// store the result (sum) of the two numbers
int result = firstNumber + secondNumber; 

// print the result for the user
Console.WriteLine("The result is:");
Console.WriteLine(firstNumber + " + " + secondNumber + " = " + result);