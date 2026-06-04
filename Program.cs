Console.Clear();
// Control flow intro

// greeting based on time of day App
// give a greeting if time of day is a number (0-23) or else tell user the time is invalid

// if hour is >= 0 and <= 11 Say good night
// if hour < 12 say "Good morning"
// if hour > 12 say "Good afternoon"
// if hour > 17 say "Good evening"

int hour = 0;

// AND operator: &&
// OR operator: ||

if (hour < 0)
{
    // show error msg
}
if (hour > 23)
{
    // also show same error msg
}

// Example of && (and operator)
// Console.Write(true && true); // true and true is true
// Console.Write(false && true); // any combination of true and false is false
// Console.Write(true && true  && true  && true  && true);

// Example of || (and operator)
// Console.Write(false || false || false); // true or true is true

// combinatio of both OR + AND

Console.Write(true && false || true);

// we can use () to order the statement groups as we wish
Console.Write(true && (false || true));