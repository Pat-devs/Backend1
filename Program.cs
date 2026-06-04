Console.Clear();
// Control flow intro

// What a conditional has to 'compute' to? Is a boolean (true or false).

// how make things "truthy" or "falsy"

// Console.WriteLine(2 > 2); // > operator checks if the left side is larger than the right side and computes to either true or false

// Console.WriteLine(2 < 2); // as line above but the opposite way (left vs right)

// Console.WriteLine(5 > 4); // True

// Console.WriteLine(5 == 5); // == checks for equality: True
// Console.WriteLine(5 == -5); // == checks for equality: False

// Not equal to
//Console.WriteLine(2 != 2); // ! means NOT. So we ask if 2 does not euqual 2.: False
//Console.WriteLine(500 != 400); // True

// Console.WriteLine(!true); // ! infront of a "truthy statemet" inverts it to False
// Console.WriteLine(!!false); // this will flip the "false" twice (to true, then again to false)
// Console.WriteLine(!!!!!!!!!!!!!!false); // We can supply multiple not operators 

int userAge = 25;

// Console.WriteLine(userAge >= 18); // check number is 18 og greater

// Console.WriteLine(userAge <= 50); // check if number is less or equal to something

// Single check: greet the user if they are an adult (18+)

if (userAge >= 18)
{
    // code inside here runs only if condition (userAge >= 18) is Truthy
    Console.WriteLine("Hello, welcome in!");
}

// code here runs anyway, regardless of userAge value

Console.WriteLine("We cannot allow you in!");

