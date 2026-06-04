// Control flow intro

// string myText = "Hi"; // "public"



// Example scope
{
    string myText = "Hi";

    Console.WriteLine("Line 1");
    Console.WriteLine("Line 2");
    Console.WriteLine("Line 3");


    Console.WriteLine(myText);
}


// What a conditional has to 'compute' to? Is a boolean (true or false).

if (true)
{
    // scope of the if staement
    Console.WriteLine("Line 4");

    Console.WriteLine(myText);
}

Console.WriteLine(myText);