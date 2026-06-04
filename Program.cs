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

Console.WriteLine(!true); // ! infront of a "truthy statemet" inverts it to False
Console.WriteLine(!!false); // this will flip the "false" twice (to true, then again to false)
Console.WriteLine(!!!!!!!!!!!!!!false); // We can supply multiple not operators 