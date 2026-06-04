Console.Clear();
// Control flow intro

// check if a number is even or odd and print proper message


string secretPassword = "l33th4x0r";

Console.Write("Enter password: ");
string userInputPassword = Console.ReadLine();

// check if user entered correct password
if (userInputPassword == secretPassword)
{
    Console.WriteLine("Access Granted!");
}
else
{
    Console.WriteLine("Access Denied!");
}
